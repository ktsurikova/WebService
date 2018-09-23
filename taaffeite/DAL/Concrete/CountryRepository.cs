using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using Neo4jClient;
using ORMNeo;
using ORMNeo.Entities;
using DAL;

namespace DAL.Concrete
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IGraphClient _client;

        public CountryRepository()
        {
            _client = NeoClient.Create().Client;
        }

        public Country GetById(Guid key)
        {
            var result = _client.Cypher.Match("(s:Shop)-[:LocatedAt]->(c:City)-[r:LocatedAt]->(co:Country)").Where((ORMCountry co) => co.Id == key).
                Return((co, c, s) => new
                {
                    Country = co.As<ORMCountry>(),
                    Cities = c.CollectAs<ORMCity>()
                }).Results.FirstOrDefault();

            return new Country()
            {
                Id = result.Country.Id,
                Name = result.Country.Name,
                Cities = result.Cities.Select(c => c.ToCity())
            };
        }

        public bool Insert(Country entity)
        {
            _client.Cypher
                .Create("(country:Country {c})")
                .WithParam("c", entity.ToORMCountry())
                .ExecuteWithoutResults();

            //foreach (var city in entity.Cities)
            //{
            //    _client.Cypher.Create("(city:City {c1})")
            //        .WithParam("c1", city.ToORMCity())
            //        .ExecuteWithoutResults();

            //    _client.Cypher
            //        .Match("(c:City)", "(co:Country)")
            //        .Where((ORMCity c) => c.Name == city.Name)
            //        .AndWhere((ORMCountry co) => co.Name == entity.Name)
            //        .Create("(c)-[:" + Relation.LocatedAt + "]->(co)")
            //        .ExecuteWithoutResults();
            //}

            return true;
        }

        public bool Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAll()
        {
            return _client.Cypher.Match("(c:Country)").Return(c => c.As<ORMCountry>()).Results
                .Select(c => c.ToCountry()).ToList();
        }
    }
}
