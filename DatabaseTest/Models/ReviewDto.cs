using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Models
{
    public class ReviewDto
    {
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public int Rating { get; set; }
        public string ReviewContent { get; set; }
    }
}
