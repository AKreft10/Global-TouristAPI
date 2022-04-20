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
        private readonly IAccommodationService _service;

        public AccommodationController(IAccommodationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<AccommodationDto>>> GetAllAccommodations()
        {
            var accommodations = await _service.GetAllAccommodations();
            return accommodations;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccommodationDto>> GetSingleAccomodation(int id)
        {
            var accommodation = await _service.GetSingleAccomodation(id);
            return accommodation;
        }
    }
}
