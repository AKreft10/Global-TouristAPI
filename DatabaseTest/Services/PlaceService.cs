using AutoMapper;
using DatabaseTest.Entity;
using DatabaseTest.Exceptions;
using DatabaseTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IDistanceService _distanceService;

        public PlaceService(DatabaseContext context, IMapper mapper, IDistanceService distanceService)
        {
            _context = context;
            _mapper = mapper;
            _distanceService = distanceService;
        }

        public async Task<List<PlaceDto>> GetAllPlaces()
        {
            var places =  await _context
                .Places
                .Include(a => a.Address)
                .Include(p => p.Photos)
                .ThenInclude(a => a.Photo)
                .Include(r => r.Reviews)
                .ThenInclude(z => z.Review)
                .ToListAsync();

            var result = _mapper.Map<List<PlaceDto>>(places);

            return result;
        }

        public async Task<PlaceDto> GetSinglePlace(int id)
        {
            var place = await GetPlaceById(id);

            if(place is null)
            {
                throw new NotFoundException("Place not found ):");
            }

            var result = _mapper.Map<PlaceDto>(place);

            return result;
        }

        public async Task<Place> GetPlaceById(int id)
        {
            var place = await _context
                .Places
                .Include(a => a.Address)
                .Include(p => p.Photos)
                .ThenInclude(a => a.Photo)
                .Include(r => r.Reviews)
                .ThenInclude(z => z.Review)
                .FirstOrDefaultAsync(p => p.Id == id);

            return place;
        }

        public async Task<IList<KeyValuePair<string, TimeAndDistanceDto>>> GetNearestAccommodations(int id)
        {
            var HotelsWithDistances = await _distanceService.GetTheNearestAccommodations(id);
            return HotelsWithDistances;
        }
    }
}
