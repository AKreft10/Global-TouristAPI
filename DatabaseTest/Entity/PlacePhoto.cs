using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class PlacePhoto
    {
        public int PlaceId { get; set; }
        [JsonIgnore]
        public Place Place { get; set; }
        public int PhotoId { get; set; }
        [JsonIgnore]
        public Photo Photo { get; set; }
    }
}
