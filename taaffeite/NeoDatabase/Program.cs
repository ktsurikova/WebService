using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo4jClient;
using Newtonsoft.Json;
using ORMNeo;
using ORMNeo.Entities;

namespace NeoDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            NeoClient client = NeoClient.Create();
            IGraphClient cl2 = client.Client;
            cl2.Connect();

            #region fill db
            //Product p1 = new Product() {Id = Guid.NewGuid(), Name = "Молоко", Measure = "л"};
            //Product p1 = new Product() { Id = Guid.NewGuid(), Name = "Индейка", Measure = "кг" };
            //Product p2 = new Product() {Id = Guid.NewGuid(), Name = "Сыр", Measure = "гр"};
            //Shop s1 = new Shop() {Id = Guid.NewGuid(), Latitude = "53.90827", Longitude = "27.46999", Name = "Green", Street = "ул. Петра Глебки", Number = "5"};
            //Shop s2 = new Shop() { Id = Guid.NewGuid(), Latitude = "53.67188", Longitude = "23.79859", Name = "Алми", Street = "ул. Советских Пограничников", Number = "110a"};
            //Shop s3 = new Shop() { Id = Guid.NewGuid(), Latitude = "53.92650", Longitude = "27.51747", Name = "Корона Техно", Street = "пр-т. Победителей", Number = "65" };
            //City c1 = new City() {Id = Guid.NewGuid(), Name = "Минск"};
            //City c2 = new City() { Id = Guid.NewGuid(), Name = "Гродно" };
            //Country co1 = new Country() {Id = Guid.NewGuid(), Name = "Беларусь"};

            //cl2.Cypher
            //    .Create("(product:Product {p1})")
            //    .WithParam("p1", p1)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(product:Product {p2})")
            //    .WithParam("p2", p2)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(shop:Shop {s1})")
            //    .WithParam("s1", s1)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(shop:Shop {s2})")
            //    .WithParam("s2", s2)
            //    .ExecuteWithoutResults();

            //Shop s3 = new Shop() { Id = Guid.NewGuid(), Latitude = "53.89479", Longitude = "27.52162", Name = "Евроопт", Street = "ул. Харьковская", Number = "72" };
            //Shop s4 = new Shop() { Id = Guid.NewGuid(), Latitude = "53.89348", Longitude = "27.58170", Name = "Евроопт", Street = "ул. Менделеева", Number = "1" };

            //cl2.Cypher
            //    .Create("(shop:Shop {s3})")
            //    .WithParam("s3", s3)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(shop:Shop {s4})")
            //    .WithParam("s4", s4)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(s:Shop)", "(c:City)")
            //    .Where((Shop s) => s.Id == s3.Id)
            //    .AndWhere((City c) => c.Name == "Минск")
            //    .Create("(s)-[:" + Relation.LocatedAt + "]->(c)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(s:Shop)", "(c:City)")
            //    .Where((Shop s) => s.Id == s4.Id)
            //    .AndWhere((City c) => c.Name == "Минск")
            //    .Create("(s)-[:" + Relation.LocatedAt + "]->(c)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(city:City {c1})")
            //    .WithParam("c1", c1)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(city:City {c2})")
            //    .WithParam("c2", c2)
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Create("(country:Country {co1})")
            //    .WithParam("co1", co1)
            //    .ExecuteWithoutResults();

            //ContainedIn link1 = new ContainedIn() { Amount = 5, Price = 10.5M };
            //cl2.Cypher
            //    .Match("(p:Product)", "(s:Shop)")
            //    .Where((Product p) => p.Name == "Индейка")
            //    .AndWhere((Shop s) => s.Name == "Green")
            //    .Create("(p)-[:" + link1.ToCreateRelation() + "]->(s)")
            //    .ExecuteWithoutResults();

            //ContainedIn link1 = new ContainedIn() { Amount = 330, Price = 1.4M };
            //cl2.Cypher
            //    .Match("(p:Product)", "(s:Shop)")
            //    .Where((Product p) => p.Name == "Молоко")
            //    .AndWhere((Shop s) => s.Name == "Алми")
            //    .Create("(p)-[:" + link1.ToCreateRelation() + "]->(s)")
            //    .ExecuteWithoutResults();

            //ContainedIn link2 = new ContainedIn() { Amount = 100, Price = 2.5M };
            //cl2.Cypher
            //    .Match("(p:Product)", "(s:Shop)")
            //    .Where((Product p) => p.Name == "Сыр")
            //    .AndWhere((Shop s) => s.Name == "Алми")
            //    .Create("(p)-[:" + link2.ToCreateRelation() + "]->(s)")
            //    .ExecuteWithoutResults();

            //ContainedIn link3 = new ContainedIn() { Amount = 50, Price = 3.1M };
            //cl2.Cypher
            //    .Match("(p:Product)", "(s:Shop)")
            //    .Where((Product p) => p.Name == "Сыр")
            //    .AndWhere((Shop s) => s.Name == "Green")
            //    .Create("(p)-[:" + link3.ToCreateRelation() + "]->(s)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(s:Shop)", "(c:City)")
            //    .Where((Shop s) => s.Name == "Green")
            //    .AndWhere((City c) => c.Name == "Минск")
            //    .Create("(s)-[:" + Relation.LocatedAt + "]->(c)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(s:Shop)", "(c:City)")
            //    .Where((Shop s) => s.Name == "Алми")
            //    .AndWhere((City c) => c.Name == "Гродно")
            //    .Create("(s)-[:" + Relation.LocatedAt + "]->(c)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(s:Shop)", "(c:City)")
            //    .Where((Shop s) => s.Name == "Корона Техно")
            //    .AndWhere((City c) => c.Name == "Минск")
            //    .Create("(s)-[:" + Relation.LocatedAt + "]->(c)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(c:City)", "(co:Country)")
            //    .Where((City c) => c.Name == "Минск")
            //    .AndWhere((Country co) => co.Name == "Беларусь")
            //    .Create("(c)-[:" + Relation.LocatedAt + "]->(co)")
            //    .ExecuteWithoutResults();

            //cl2.Cypher
            //    .Match("(c:City)", "(co:Country)")
            //    .Where((City c) => c.Name == "Гродно")
            //    .AndWhere((Country co) => co.Name == "Беларусь")
            //    .Create("(c)-[:" + Relation.LocatedAt + "]->(co)")
            //    .ExecuteWithoutResults();

            //Product p3 = new Product() {Id = Guid.NewGuid(), Measure = "шт", Name = "Холодильник"};

            //cl2.Cypher
            //    .Create("(product:Product {p3})")
            //    .WithParam("p3", p3)
            //    .ExecuteWithoutResults();

            //ContainedIn link2 = new ContainedIn() { Amount = 2, Price = 995.9M };
            //cl2.Cypher
            //    .Match("(p:Product)", "(s:Shop)")
            //    .Where((Product p) => p.Name == "Холодильник")
            //    .AndWhere((Shop s) => s.Name == "Корона Техно")
            //    .Create("(p)-[:" + link2.ToCreateRelation() + "]->(s)")
            //    .ExecuteWithoutResults(); 
            #endregion

            //var r1 = 
            //cl2.Cypher.Match("(p:Product) -[r: Located_At]->(s: Shop)")
            //    .Where((Product p, ContainedIn r, Shop s) => p.Name == "Milk" && s.Name=="Walmart" && r.Price<2).Return((p, r, s) => new
            //    {
            //        Product = p.As<Product>(),
            //        Location = r.As<ContainedIn>(),
            //        Shop = s.As<Shop>()
            //    }).Results;

            //create(p: Product { Id: "7312754D-7582-4BA7-B42B-009DFDFF5EC6", Measure: "1 кг", Name: "Курица"})

            //var rty = new UriBuilder() {Scheme = Uri.UriSchemeFile, Host = "", Path = @"C:\Users\user\Desktop\Product.csv" }.Uri;

            //cl2.Cypher.LoadCsv( rty, "line", true)
            //    .Create($"(:Product {{ Id: \"{Guid.NewGuid()}\", Name: line.Name, Measure: line.Measure}})").ExecuteWithoutResults();




            //using (StreamReader r = new StreamReader("D:\\univer\\webService\\taaffeite\\NeoDatabase\\Product.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Product> items = JsonConvert.DeserializeObject<List<Product>>(json);

            //    for (int i = 0; i < items.Count; i++)
            //    {
            //        items[i].Id = Guid.NewGuid();

            //        cl2.Cypher
            //            .Create("(product:Product {p1})")
            //            .WithParam("p1", items[i])
            //            .ExecuteWithoutResults();
            //    }
            //}

            using (StreamReader r = new StreamReader("D:\\univer\\webService\\taaffeite\\NeoDatabase\\Connection.json"))
            {
                string json = r.ReadToEnd();
                var array = JsonConvert.DeserializeObject<List<Connection>>(json);

                foreach (var item in array)
                {
                    ORMContainedIn link1 = new ORMContainedIn { Amount = item.Amount, Price = item.Price };
                    cl2.Cypher
                        .Match("(p:Product)", "(s:Shop)")
                        .Where((ORMProduct p) => p.Name == item.ProductName)
                        .AndWhere((ORMShop s) => s.Id == item.ShopId)
                        .Create("(p)-[:" + link1.ToCreateRelation() + "]->(s)")
                        .ExecuteWithoutResults();
                }
            }


            //using (StreamReader r = new StreamReader("D:\\univer\\webService\\taaffeite\\NeoDatabase\\Shop.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Shop> items = JsonConvert.DeserializeObject<List<Shop>>(json);

            //    for (int i = 0; i < items.Count; i++)
            //    {
            //        items[i].Id = Guid.NewGuid();

            //        cl2.Cypher
            //            .Create("(shop:Shop {p1})")
            //            .WithParam("p1", items[i])
            //            .ExecuteWithoutResults();
            //    }
            //}


            Console.WriteLine("ready");
        }
    }
}
