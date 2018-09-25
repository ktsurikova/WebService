using DAL.Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Interface
{
    public interface IProductService
    {
        Product GetNearest(string name, double longitude, double latitude);
        Product GetCheapestInCity(string productName, string cityName);
        Dictionary<Shop, decimal> GetCheapestInCity(IEnumerable<string> products, string cityName);
        Dictionary<Shop, decimal> GetNearest(IEnumerable<string> products, double lat, double lon);
        List<string> SearchForKeyword(string keyword);
    }
}
