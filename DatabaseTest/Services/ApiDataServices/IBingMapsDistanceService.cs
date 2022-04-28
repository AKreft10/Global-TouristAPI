using DatabaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services.ApiDataServices
{
    public interface IBingMapsDistanceService
    {
        Task<TimeAndDistanceDto> GetTimeAndDistance(CoordinatesDto accommodationCords, CoordinatesDto placeCoords);
    }
}
