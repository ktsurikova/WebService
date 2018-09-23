using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class City : IEntity
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
