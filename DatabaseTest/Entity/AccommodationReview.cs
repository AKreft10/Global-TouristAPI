using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class AccommodationReview
    {
        public int AccommodationId { get; set; }
        public Accommodation Accomodation { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
