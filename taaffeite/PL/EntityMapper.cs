using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PL.Entities;

namespace PL
{
    public static class EntityMapper
    {
        public static City ToCity(this DAL.Interface.DTO.City city)
        {
            return new City()
            {
                Id = city.Id,
                Name = city.Name
            };
        }

        public static Country ToCountry(this DAL.Interface.DTO.Country country)
        {
            return new Country()
            {
                Id = country.Id,
                Name = country.Name
            };
        }

        public static Shop ToShop(this DAL.Interface.DTO.Shop shop)
        {
            return new Shop()
            {
                //City = shop.City.ToCity(),
                Id = shop.Id,
                Latitude = shop.Latitude,
                Longitude = shop.Longitude,
                Name = shop.Name,
                Number = shop.Number,
                Street = shop.Street
            };
        }

        public static ContainedIn ToContainedIn(this DAL.Interface.DTO.ContainedIn containedIn)
        {
            return new ContainedIn()
            {
                Amount = containedIn.Amount,
                Price = containedIn.Price
            };
        }

        public static Product ToProduct(this DAL.Interface.DTO.Product product)
        {
            return new Product()
            {
                Id = product.Id,
                Measure = product.Measure,
                Name = product.Name
            };
        }
    }
}