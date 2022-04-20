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
    [Route("api/review")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost("{id}")]
        public async Task<ActionResult> AddReview([FromRoute] int id, [FromBody] ReviewDto dto)
        {
            await _reviewService.AddReviewToAccommodation(id, dto);
            return Created("", null);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteReviewById(int id)
        {
            await _reviewService.DeleteReviewById(id);
            return NoContent();
        }
    }
}
