using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Models
{
    public class CreateAccommodationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Stars { get; set; }
        public bool? HasPool { get; set; }
        #nullable enable
        public string? Thumbnail { get; set; }
        #nullable disable
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
