using DatabaseTest.Entity;
using DatabaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public interface IPlaceService
    {
        Task<List<PlaceDto>> GetAllPlaces();
        Task<PlaceDto> GetSinglePlace(int id);
        Task<IList<KeyValuePair<string, TimeAndDistanceDto>>> GetNearestAccommodations(int id);
    }
}
