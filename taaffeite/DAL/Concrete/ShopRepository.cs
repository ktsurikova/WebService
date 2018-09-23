using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ShopRepository : IShopRepository
    {
        private readonly IGraphClient _client;
        private const int ItemsMax = 7;

        public ShopRepository()
        {
            _client = NeoClient.Create().Client;
        }

        public Shop GetById(Guid key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Shop entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Shop entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Shop entity)
        {
            throw new NotImplementedException();
        }

        public List<Shop> GetAllShopsInCity(string cityName)
        {
            var res = _client.Cypher.Match("(s:Shop)-[:LocatedAt]->(c:City)")
                .Where<ORMCity>(c => c.Name == cityName)
                .Return((s, c) => new
                {
                    City = c.As<ORMCity>(),
                    Shops = s.CollectAs<ORMShop>()
                }).Results.FirstOrDefault();

            return Construct(res.City, res.Shops);
        }

        private List<Shop> Construct(ORMCity city, IEnumerable<ORMShop> shops)
        {
            List<Shop> result = new List<Shop>(shops.Count());
            result.AddRange(shops.Select(shop => shop.ToShop()));
            City c = city.ToCity();
            c.Shops = result;
            for (int i = 0; i < result.Count; i++)
            {
                result[i].City = c;
            }
            return result;
        }
    }
}
