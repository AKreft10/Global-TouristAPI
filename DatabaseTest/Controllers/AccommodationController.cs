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
    [Route("api/accommodation")]
    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationService _accommodationService;

        public AccommodationController(IAccommodationService accommodationService)
        {
            _accommodationService = accommodationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AccommodationDto>>> GetAllAccommodations()
        {
            var accommodations = await _accommodationService.GetAllAccommodations();
            return accommodations;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccommodationDto>> GetSingleAccomodation(int id)
        {
            var accommodation = await _accommodationService.GetSingleAccomodation(id);
            return accommodation;
        }

        //Admin Endpoints

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAccommodationById(int id)
        {
            await _accommodationService.DeleteAccommodationById(id);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> CreateAccommodation([FromBody]CreateAccommodationDto dto)
        {
            var result = await _accommodationService.CreateAccommodation(dto);
            return Created($"/api/accommodation/{result}", null);
        }
    }
}
