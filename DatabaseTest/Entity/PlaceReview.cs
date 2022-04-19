using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class PlaceReview
    {
        public int PlaceId { get; set; }
        [JsonIgnore]
        public Place Place { get; set; }
        public int ReviewId { get; set; }
        [JsonIgnore]
        public Review Review { get; set; }
    }
}
