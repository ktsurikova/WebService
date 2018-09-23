using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ORMNeo.Entities
{
    public class ORMShop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
