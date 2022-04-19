using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class Review
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public int Rating { get; set; }
        public string ReviewContent { get; set; }
        public ICollection<AccommodationReview> AccommodationReviews { get; set; }
        public ICollection<PlaceReview> PlaceReviews { get; set; }
    }
}
