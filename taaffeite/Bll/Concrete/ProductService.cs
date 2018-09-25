using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.Interface;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using DAL.Concrete;

namespace Bll.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private const int ItemsMax = 7;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetNearest(string name, double longitude, double latitude)
        {
            return _productRepository.GetNearest(name, latitude, longitude);
        }

        public Product GetCheapestInCity(string productName, string cityName)
        {
            return _productRepository.GetCheapestInCity(productName, cityName, 0, 10);
        }

        public Dictionary<Shop, decimal> GetCheapestInCity(IEnumerable<string> products, string cityName)
        {
            return _productRepository.GetCheapestInCity(products, cityName);
        }

        public Dictionary<Shop, decimal> GetNearest(IEnumerable<string> products, double lat, double lon)
        {
            return _productRepository.GetNearest(products, lat, lon);
        }

        public List<string> SearchForKeyword(string keyword)
        {
            var startsWith = _productRepository.StartWithSearch(keyword);

            if (startsWith.Count < ItemsMax)
            {
                var contains = _productRepository.ContainsSearch(keyword);
                for (int i = 0; i < contains.Count; i++)
                {
                    if (!startsWith.Contains(contains[i]))
                    {
                        startsWith.Add(contains[i]);
                    }
                    if (startsWith.Count == ItemsMax)
                        break;
                }
            }

            return startsWith;
        }
    }
}
