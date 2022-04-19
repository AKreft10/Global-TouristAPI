using AutoMapper;
using DatabaseTest.Entity;
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
        private readonly PlaceDbContext _context;
        private readonly IMapper _mapper;

        public PlaceService(PlaceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PlaceDto> GetAllPlaces()
        {
            var places = _context
                .Places
                .Include(a => a.Address)
                .Include(p => p.Photos)
                .ThenInclude(a => a.Photo)
                .Include(r => r.Reviews)
                .ThenInclude(z => z.Review)
                .ToList();

            var result = _mapper.Map<List<PlaceDto>>(places);

            return result;
        }

        public PlaceDto GetSinglePlace(int id)
        {
            var place = _context
                .Places
                .Include(a => a.Address)
                .Include(p => p.Photos)
                .ThenInclude(a => a.Photo)
                .Include(r => r.Reviews)
                .ThenInclude(z => z.Review)
                .FirstOrDefault(p => p.Id == id);

                var result = _mapper.Map<PlaceDto>(place);

            return result;
        }
    }
}
