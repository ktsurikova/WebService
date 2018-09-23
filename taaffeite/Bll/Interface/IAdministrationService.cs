using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;

namespace Bll.Interface
{
    interface IAdministrationService
    {
        bool AddProduct(Product product);
        bool AddShop(Shop shop);
        bool AddCity(City city);
        bool AddCountry(Country country);

        void ConnectProductShop(Guid productId, Guid shopId, decimal price, int amount);
        void ConnectShopCity(Guid shopId, Guid cityId);
        void ConnectCityCountry(Guid cityId, Guid countryId);

        void UpdateProductShopConnection(Guid productId, Guid shopId, decimal price, int amount);

        void DisConnectProductShop(Guid productId, Guid shopId, decimal price, int amount);
        void DisConnectShopCity(Guid shopId, Guid cityId);
        void DisConnectCityCountry(Guid cityId, Guid countryId);

        bool RemoveProduct(Product product);
        bool RemoveShop(Shop shop);
        bool RemoveCity(City city);
        bool RemoveCountry(Country country);

        List<Country> GetAllCountries();
        List<City> GetAllCities(string countryName);
        List<Shop> GetAllShopsInCity(string cityName);
        List<Product> GetAllProductsInShop(Guid shopId);
    }
}
