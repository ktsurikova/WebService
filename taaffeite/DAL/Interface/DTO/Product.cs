using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class Product : IEntity
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
