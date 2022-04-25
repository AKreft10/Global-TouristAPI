using DatabaseTest.Entity;
using DatabaseTest.Models;
using DatabaseTest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Controllers
{
    [Route("api/accommodation/{accommodationId}/review")]
    public class AccommodationReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public AccommodationReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ReviewDto>>> GetReviewsByAccommodationId(int accommodationId)
        {
            var reviews = await _reviewService.GetReviewsByAccommodationId(accommodationId);
            return reviews;
        }

        [HttpPost]
        public async Task<ActionResult> AddReview([FromRoute] int accommodationId, [FromBody] ReviewDto dto)
        {
            var reviewid = await _reviewService.AddReviewToAccommodation(accommodationId, dto);
            return Created($"api/accommodation/{accommodationId}/review/{reviewid}", null);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteReviewById(int id)
        {
            await _reviewService.DeleteReviewById(id);
            return NoContent();
        }
    }
}
