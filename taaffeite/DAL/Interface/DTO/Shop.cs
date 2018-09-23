using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.DTO
{
    public class Shop : IEntity, IComparable<Shop>, IComparable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public City City { get; set; }

        public int CompareTo(Shop other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return Id.CompareTo(other.Id);
        }

        int IComparable.CompareTo(object obj)
        {
            return CompareTo(obj as Shop);
        }
    }
}
