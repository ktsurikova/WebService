using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNeo.Entities
{
    public class ORMProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
    }
}
