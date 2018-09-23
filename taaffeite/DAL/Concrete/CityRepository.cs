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

namespace DAL.Concrete
{
    public class CityRepository : ICityRepository
    {
        private readonly IGraphClient _client;

        public CityRepository()
        {
            _client = NeoClient.Create().Client;
        }

        public City GetById(Guid key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(City entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(City entity)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll(string countryName)
        {
            return _client.Cypher.Match($"(c:City)-[:LocatedAt]->(co:Country {{Name:\"{countryName}\"}})").Return(c => c.As<ORMCity>()).Results.Select(c => c.ToCity())
                .ToList();
        }
    }
}
