﻿using DatabaseTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Models
{
    public class AccommodationReviewDto
    {
        public Review Review { get; set; }
        public int AccommodationId { get; set; }
    }
}
