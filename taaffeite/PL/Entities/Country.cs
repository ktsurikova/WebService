using System;
using System.Collections.Generic;

namespace PL.Entities
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<City> Cities { get; set; }
    }
}
