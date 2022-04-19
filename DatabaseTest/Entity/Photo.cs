using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Entity
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Author { get; set; }
        public ICollection<AccommodationPhoto> AccomodationPhotos { get; set; }
        public ICollection<PlacePhoto> PlacePhotos { get; set; }
    }
}
