using System;

namespace PL.Entities
{
    public class Shop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public City City { get; set; }
    }
}
