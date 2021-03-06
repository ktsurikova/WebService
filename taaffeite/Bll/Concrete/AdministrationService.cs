﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.Interface;
using DAL.Concrete;
using DAL.Interface.DTO;
using DAL.Interface.Repository;

namespace Bll.Concrete
{
    public class AdministrationService : IAdministrationService
    {
        private readonly IShopRepository _shopRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IProductRepository _productRepository;
        private const int ItemsMax = 7;

        public AdministrationService(IProductRepository productRepository, IShopRepository shopRepository,
            ICityRepository cityRepository, ICountryRepository countryRepository)
        {
            _shopRepository = shopRepository;
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
            _productRepository = productRepository;
        }

        public bool AddProduct(Product product)
        {
            return _productRepository.Insert(product);
        }

        public bool AddShop(Shop shop)
        {
            return _shopRepository.Insert(shop);
        }

        public bool AddCity(City city)
        {
            return _cityRepository.Insert(city);
        }

        public bool AddCountry(Country country)
        {
            return _countryRepository.Insert(country);
        }

        public void ConnectProductShop(Guid productId, Guid shopId, decimal price, int amount)
        {
            throw new NotImplementedException();
        }

        public void ConnectShopCity(Guid shopId, Guid cityId)
        {
            throw new NotImplementedException();
        }

        public void ConnectCityCountry(Guid cityId, Guid countryId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductShopConnection(Guid productId, Guid shopId, decimal price, int amount)
        {
            throw new NotImplementedException();
        }

        public void DisConnectProductShop(Guid productId, Guid shopId, decimal price, int amount)
        {
            throw new NotImplementedException();
        }

        public void DisConnectShopCity(Guid shopId, Guid cityId)
        {
            throw new NotImplementedException();
        }

        public void DisConnectCityCountry(Guid cityId, Guid countryId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool RemoveShop(Shop shop)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCity(City city)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAllCountries()
        {
            return _countryRepository.GetAll();
        }

        public List<City> GetAllCities(string countryName)
        {
            return _cityRepository.GetAll(countryName);
        }

        public List<Shop> GetAllShopsInCity(string cityName)
        {
            return _shopRepository.GetAllShopsInCity(cityName);
        }

        public List<Product> GetAllProductsInShop(Guid shopId)
        {
            return _productRepository.GetAllProductsInShop(shopId);
        }
    }
}
