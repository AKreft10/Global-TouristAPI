using DatabaseTest.Entity;
using DatabaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public interface IReviewService
    {
        Task AddReviewToAccommodation(int id, ReviewDto dto);
        Task DeleteReviewById(int id);
        Task<List<ReviewDto>> GetReviewsByAccommodationId(int id);
    }
}
