using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class Accommodation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AddressId { get; set; }
        public int? Stars { get; set; }
        public bool? HasPool { get; set; }
        public virtual Address Address { get; set; }
        public ICollection<AccommodationPhoto> Photos { get; set; }
        public ICollection<AccommodationReview> Reviews { get; set; }
    }
}
