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
    public class AccommodationService : IAccommodationService
    {
        private readonly Entity.DatabaseContext _context;
        private readonly IMapper _mapper;

        public AccommodationService(Entity.DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<AccommodationDto>> GetAllAccommodations()
        {
            var accommodations = await _context
                .Accommodations
                .Include(a => a.Address)
                .Include(p => p.Photos)
                .ThenInclude(a => a.Photo)
                .Include(r => r.Reviews)
                .ThenInclude(y => y.Review)
                .ToListAsync();

            var result = _mapper.Map<List<AccommodationDto>>(accommodations);

            return result;
        }

        public async Task<AccommodationDto> GetSingleAccomodation(int id)
        {
            var accommodation = await GetAccomodationById(id);

            var result = _mapper.Map<AccommodationDto>(accommodation);

            return result;
        }

        public async Task DeleteAccommodationById(int id)
        {
            var accommodation = await GetAccomodationById(id);

            _context.Remove(accommodation);
            await _context.SaveChangesAsync();
        }

        private async Task<Accommodation> GetAccomodationById(int id)
        {
            var accommodation = await _context
                .Accommodations
                .Include(e => e.Address)
                .Include(p => p.Photos)
                .ThenInclude(a => a.Photo)
                .Include(r => r.Reviews)
                .ThenInclude(y => y.Review)
                .FirstOrDefaultAsync(a => a.Id == id);

            return accommodation;
        }

        public async Task<int> CreateAccommodation(CreateAccommodationDto dto)
        {
            var accommodation = _mapper.Map<Accommodation>(dto);
            await _context.Accommodations.AddAsync(accommodation);
            await _context.SaveChangesAsync();

            return accommodation.Id;
        }
    }
}
