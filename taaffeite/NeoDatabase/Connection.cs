using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoDatabase
{
    class Connection
    {
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string ProductName { get; set; }
        public Guid ShopId { get; set; }
    }
}
