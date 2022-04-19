using DatabaseTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly PlaceDbContext _context;

        public PlaceService(PlaceDbContext context)
        {
            _context = context;
        }

        public List<Place> GetAllPlaces()
        {
            var places = _context
                .Places
                .ToList();

            return places;
        }

        public Place GetSinglePlace(int id)
        {
            var place = _context
                .Places.FirstOrDefault(p => p.Id == id);

            return place;
        }
    }
}
