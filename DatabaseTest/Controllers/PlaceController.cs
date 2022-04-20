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
    [Route("api/place")]
    public class PlaceController : ControllerBase
    {
        private readonly IPlaceService _service;

        public PlaceController(IPlaceService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlaceDto>>> GetAllPlaces()
        {
            var places = await _service.GetAllPlaces();
            return places;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Place>> GetSinglePlace(int id)
        {
            var place = await _service.GetSinglePlace(id);
            return Ok(place);
        }

    }
}
