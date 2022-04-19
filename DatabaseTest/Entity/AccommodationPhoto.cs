using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class AccommodationPhoto
    {
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
