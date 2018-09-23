using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using Neo4jClient;
using Neo4jClient.Cypher;
using ORMNeo;
using ORMNeo.Entities;

namespace DAL.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly IGraphClient _client;
        private const int ItemsMax = 7;

        public ProductRepository()
        {
            _client = NeoClient.Create().Client;
        }

        public Product GetById(Guid key)
        {
            return GetByCriteria(p => p.Id == key);
        }

        public Product GetByName(string name)
        {
            return GetByCriteria(p => p.Name == name);
        }

        private Product GetByCriteria(Expression<Func<ORMProduct, bool>> criteria)
        {
            var result = _client.Cypher.Match("(p:Product)-[r:ContainedIn]->(s:Shop)")
                .Where(criteria)
                .Return((p, r, s) => new
                {
                    Products = p.CollectAs<ORMProduct>(),
                    Cont = r.CollectAs<ORMContainedIn>(),
                    Shops = s.CollectAs<ORMShop>()
                }).Results.FirstOrDefault();

            ORMProduct pr = result.Products.FirstOrDefault();

            return FillDalProduct(pr, result.Shops.ToList(), result.Cont.ToList());
        }

        public bool Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetNearest(string productName, double lat, double lon, int skip = 0, int take = 10)
        {
            var result = _client.Cypher.Match("(p:Product)-[r: ContainedIn]->(s:Shop)")
                .Where<ORMProduct>(p => p.Name == productName)
                .Return((p, s, r) => new
                {
                    Product = p.As<ORMProduct>(),
                    Cont = r.As<ORMContainedIn>(),
                    Shop = s.As<ORMShop>(),
                    Dist = Return.As<double>("distance(point({ latitude: toFloat(s.Latitude), longitude: toFloat(s.Longitude)}),point({ latitude: " +
                                             lat + ", longitude: " + lon + "}))")

                }).OrderBy("Dist").Skip(skip).Limit(take).Results;

            ORMProduct pr = result.First().Product;
            Product product = new Product()
            {
                Id = pr.Id,
                Name = pr.Name,
                Shops = new Dictionary<Shop, ContainedIn>()
            };

            foreach (var res in result)
            {
                product.Shops.Add(res.Shop.ToShop(), res.Cont.ToContainedIn());
            }

            return product;
        }

        public Product GetCheapestInCity(string productName, string cityName, int skip, int take)
        {
            var result = _client.Cypher.Match("(p:Product)-[r:ContainedIn]->(s:Shop)-[l:LocatedAt]->(c:City)")
                .Where<ORMProduct>(p => p.Name == productName)
                .AndWhere<ORMCity>(c => c.Name == cityName)
                .Return((p, r, s) => new
                {
                    Product = p.As<ORMProduct>(),
                    Cont = r.As<ORMContainedIn>(),
                    Shop = s.As<ORMShop>()
                }).OrderBy("Cont.Price").Skip(skip).Limit(take).Results;

            ORMProduct pr = result.First().Product;
            Product product = new Product()
            {
                Id = pr.Id,
                Name = pr.Name,
                Shops = new Dictionary<Shop, ContainedIn>()
            };

            foreach (var res in result)
            {
                product.Shops.Add(res.Shop.ToShop(), res.Cont.ToContainedIn());
            }

            return product;
        }

        public Dictionary<Shop, decimal> GetCheapestInCity(IEnumerable<string> products, string cityName)
        {
            var results = _client.Cypher.With("[" + ConstructWith(products) + "] as names")
                .Match($"(p: Product) -[l: ContainedIn]->(s: Shop), (c:City{{ Name: \"{cityName}\"}})")
                .Where("p.Name in names and (s) -[:LocatedAt]->(c)")
                .With("s, size(names) as inputCnt, count(DISTINCT p) as cnt, sum(l.Price) as sum")
                .Where("cnt = inputCnt")
                .Return((s, sum) => new
                {
                    Shop = s.As<ORMShop>(),
                    Price = Return.As<decimal>("sum")
                })
                .OrderBy("sum").Results;

            Dictionary<Shop, decimal> dict = new Dictionary<Shop, decimal>();
            foreach (var res in results)
            {
                dict.Add(res.Shop.ToShop(), res.Price);
            }

            return dict;
        }

        public Dictionary<Shop, decimal> GetNearest(IEnumerable<string> products, double lat, double lon)
        {
            var results = _client.Cypher.With("[" + ConstructWith(products) + "] as names")
                .Match("(p: Product) -[l: ContainedIn]->(s: Shop)")
                .Where("p.Name in names")
                .With("s, size(names) as inputCnt, count(DISTINCT p) as cnt, sum(l.Price) as sum," +
                      $"distance(point({{ latitude: toFloat(s.Latitude), longitude: toFloat(s.Longitude)}}),point({{ latitude: {lat}, longitude: {lon}}})) as dist")
                .Where("cnt = inputCnt")
                .Return((s, sum) => new
                {
                    Shop = s.As<ORMShop>(),
                    Price = Return.As<decimal>("sum"),
                    Dist = Return.As<double>("dist")
                })
                .OrderBy("dist").Results;


            Dictionary<Shop, decimal> dict = new Dictionary<Shop, decimal>();
            foreach (var res in results)
            {
                dict.Add(res.Shop.ToShop(), res.Price);
            }

            return dict;
        }

        public List<string> StartWithSearch(string name)
        {
            return _client.Cypher.Match("(p:Product)").Where<ORMProduct>(p => p.Name.StartsWith(name))
                .Return(p => p.As<ORMProduct>()).Limit(ItemsMax).Results.Select(p => p.Name).ToList();
        }

        public List<string> ContainsSearch(string name)
        {
            return _client.Cypher.Match("(p:Product)").Where<ORMProduct>(p => p.Name.Contains(name))
                .Return(p => p.As<ORMProduct>()).Limit(ItemsMax).Results.Select(p => p.Name).ToList();
        }

        public List<Product> GetAllProductsInShop(Guid shopId)
        {
            var result = _client.Cypher.Match("(p:Product)-[:ContainedIn]->(s:Shop)")
                .Where<ORMShop>(s => s.Id == shopId)
                .Return((s, p) => new
                {
                    Shop = s.As<ORMShop>(),
                    Products = p.CollectAs<ORMProduct>()
                }).Results.FirstOrDefault();

            List<Product> products = new List<Product>(result.Products.Count());
            foreach (var p in result.Products)
            {
                products.Add(p.ToProduct());
            }

            return products;
        }

        //public Dictionary<Shop, double> GetOpt(string productName1, string productName2, string cityName)
        //{
        //    var result = _client.Cypher.Match($"(p1:Product {{Name: \"{productName1}\"}})-[l:ContainedIn]->(s:Shop)<-[r:ContainedIn]-(p2:Product {{Name: \"{productName2}\"}}), (c:City {{Name:\"{cityName}\"}})")
        //        .Where("(s)-[:LocatedAt]->(c)")
        //        .Return((s, l, r) => new
        //        {
        //            Shop = s.As<Shop>(),
        //            Sum = Return.As<double>("l.Price + r.Price")

        //        }).OrderBy("Sum").Results;

        //    Dictionary<Shop, double> dict = new Dictionary<Shop, double>();
        //    foreach (var res in result)
        //    {
        //        dict.Add(res.Shop.ToShop(), res.Sum);
        //    }

        //    return dict;
        //}

        private Product FillDalProduct(ORMProduct pr, List<ORMShop> shops, List<ORMContainedIn> links)
        {
            Product product = new Product()
            {
                Id = pr.Id,
                Measure = pr.Measure,
                Name = pr.Name
            };

            for (int i = 0; i < links.Count; i++)
            {
                product.Shops.Add(shops[i].ToShop(), links[i].ToContainedIn());
            }

            return product;
        }

        private string ConstructWith(IEnumerable<string> products)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var p in products)
            {
                sb.Append($"'{p}', ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
