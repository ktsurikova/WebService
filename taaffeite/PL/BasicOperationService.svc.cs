using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Bll.Concrete;
using PL.Entities;
using Bll.Interface;
using DAL.Concrete;

namespace PL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BasicOperationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BasicOperationService.svc or BasicOperationService.svc.cs at the Solution Explorer and start debugging.
    public class BasicOperationService : IBasicOperationService
    {
        private readonly IProductService _productService;

        public BasicOperationService()
        {
            _productService = new ProductService(new ProductRepository());
        }

        public BasicOperationService(IProductService productService)
        {
            _productService = productService; 
        }

        public Product GetNearest(string name, double longitude, double latitude)
        {
            return _productService.GetNearest(name, longitude, latitude).ToProduct();
        }

        public Product GetCheapestInCity(string productName, string cityName)
        {
            return _productService.GetCheapestInCity(productName, cityName).ToProduct();
        }

        public Dictionary<Shop, decimal> GetManyCheapestInCity(IEnumerable<string> products, string cityName)
        {
            var dict =  _productService.GetCheapestInCity(products, cityName);
            Dictionary<Shop, decimal> result = new Dictionary<Shop, decimal>(dict.Count);
            foreach (var key in dict.Keys)
            {
                result.Add(key.ToShop(), dict[key]);
            }
            return result;
        }

        public Dictionary<Shop, decimal> GetManyNearest(IEnumerable<string> products, double lat, double lon)
        {
            var dict = _productService.GetNearest(products, lat, lon);
            Dictionary<Shop, decimal> result = new Dictionary<Shop, decimal>(dict.Count);
            foreach (var key in dict.Keys)
            {
                result.Add(key.ToShop(), dict[key]);
            }
            return result;
        }

        public List<string> SearchForKeyword(string keyword)
        {
            return _productService.SearchForKeyword(keyword);
        }
    }
}
