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
    public class ReviewService : IReviewService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public ReviewService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddReviewToAccommodation(int id, ReviewDto dto)
        {
            var result = _mapper.Map<Review>(dto);

            result.CreationDate = DateTime.Now;

            var accommodationReview = new AccommodationReviewDto()
            {
                Review = result,
                AccommodationId = id
            };

            var mappedReview = _mapper.Map<AccommodationReview>(accommodationReview);

            await _context.AccommodationReviews.AddAsync(mappedReview);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReviewById(int id)
        {
            var review = await _context
                .Reviews
                .FirstOrDefaultAsync(r => r.Id == id);

            _context.Remove(review);
            await _context.SaveChangesAsync();
        }
    }
}
