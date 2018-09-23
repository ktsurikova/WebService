using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace DAL.Interface.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByName(string name);
        Product GetNearest(string productName, double lat, double lon, int skip = 0, int take = 10);
        Product GetCheapestInCity(string productName, string cityName, int skip, int take);
        Dictionary<Shop, decimal> GetCheapestInCity(IEnumerable<string> products, string cityName);
        Dictionary<Shop, decimal> GetNearest(IEnumerable<string> products, double lat, double lon);
        //Dictionary<Shop, double> GetOpt(string productName1, string productName2, string cityName);
        List<string> StartWithSearch(string name);
        List<string> ContainsSearch(string name);
        List<Product> GetAllProductsInShop(Guid shopId);
    }
}
