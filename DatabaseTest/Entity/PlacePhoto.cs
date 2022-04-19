using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class PlacePhoto
    {
        public int PlaceId { get; set; }
        public Place Place { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
