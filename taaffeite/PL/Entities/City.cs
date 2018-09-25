using System;
using System.Collections.Generic;

namespace PL.Entities
{
    public class City
    {
        public City()
        {
            Shops = new List<Shop>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Shop> Shops { get; set; }
    }
}
