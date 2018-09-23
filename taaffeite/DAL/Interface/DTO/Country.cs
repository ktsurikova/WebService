using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class Country : IEntity
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
