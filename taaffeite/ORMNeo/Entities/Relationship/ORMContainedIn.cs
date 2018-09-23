using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMNeo.Entities
{
    public class ORMContainedIn
    {
        public decimal Price { get; set; }
        public decimal Amount { get; set; }

        public string ToCreateRelation()
        {
            return $"{Relation.ContainedIn}{{ Price: {Price}, Amount: {Amount}}}";
        }
    }
}
