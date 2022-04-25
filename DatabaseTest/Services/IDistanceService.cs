using DatabaseTest.Entity;
using DatabaseTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public interface IDistanceService
    {
        Task<IList<KeyValuePair<string, TimeAndDistanceDto>>> GetTheNearestAccommodations(int id);
    }
}
