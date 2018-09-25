using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.DTO;
using ORMNeo.Entities;

namespace DAL
{
    public static class DalEntityMapper
    {
        public static Country ToCountry(this ORMCountry country)
        {
            return new Country()
            {
                Id = country.Id,
                Name = country.Name
            };
        }

        public static City ToCity(this ORMCity city)
        {
            return new City()
            {
                Id = city.Id,
                Name = city.Name,
                Shops = null
            };
        }


        public static ORMCountry ToORMCountry(this Country country)
        {
            return new ORMCountry()
            {
                Id = country.Id,
                Name = country.Name
            };
        }

        public static ORMCity ToORMCity(this City city)
        {
            return new ORMCity()
            {
                Id = city.Id,
                Name = city.Name
            };
        }

        public static Shop ToShop(this ORMShop shop)
        {
            return new Shop()
            {
                Id = shop.Id,
                Longitude = shop.Longitude,
                Latitude = shop.Latitude,
                Name = shop.Name,
                Street = shop.Street,
                Number = shop.Number
            };
        }

        public static ContainedIn ToContainedIn(this ORMContainedIn containedIn)
        {
            return new ContainedIn()
            {
                Amount = containedIn.Amount,
                Price = containedIn.Price
            };
        }

        public static Product ToProduct(this ORMProduct ormProduct)
        {
            return new Product()
            {
                Id = ormProduct.Id,
                Measure = ormProduct.Measure,
                Name = ormProduct.Name
            };
        }

        public static ORMProduct ToORMProduct(this Product product)
        {
            return new ORMProduct()
            {
                Id = product.Id,
                Measure = product.Measure,
                Name = product.Name
            };
        }

        public static ORMShop ToORMShop(this Shop shop)
        {
            return new ORMShop()
            {
                Id = shop.Id,
                Latitude = shop.Latitude,
                Longitude = shop.Longitude,
                Name = shop.Name,
                Number = shop.Number,
                Street = shop.Street
            };
        }
    }
}
