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
        public ActionResult<List<PlaceDto>> GetAllPlaces()
        {
            var places = _service.GetAllPlaces();
            return places;
        }

        [HttpGet("{id}")]
        public ActionResult<Place> GetSinglePlace(int id)
        {
            var place = _service.GetSinglePlace(id);
            return Ok(place);
        }
    }
}
