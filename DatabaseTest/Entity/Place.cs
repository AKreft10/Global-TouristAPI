using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #nullable enable
        public string? ThumbnailPhoto { get; set; }
        #nullable disable
        public int AddressId { get; set; }
        [JsonIgnore]
        public virtual Address Address { get; set; }
        public ICollection<PlacePhoto> Photos { get; set; }
        public ICollection<PlaceReview> Reviews { get; set; }
    }
}
