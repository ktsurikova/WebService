using System;
using System.Collections.Generic;

namespace PL.Entities
{
    public class Product
    {
        public Product()
        {
            Shops = new Dictionary<Shop, ContainedIn>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }

        public Dictionary<Shop, ContainedIn> Shops { get; set; }
    }
}
