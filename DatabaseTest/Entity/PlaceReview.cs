using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class PlaceReview
    {
        public int PlaceId { get; set; }
        public Place Place { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
