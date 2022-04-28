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
    [Route("api/place/{placeId}")]
    public class PlacePhotoController : ControllerBase
    {
        private readonly IPhotoService _service;

        public PlacePhotoController(IPhotoService service)
        {
            _service = service;
        }

        [HttpGet("photos")]
        public async Task<ActionResult<List<PhotoDto>>> GetAllPhotosOfThePlace(int placeId)
        {
            var result = await _service.GetAllPhotos(placeId);
            return result;
        }

        [HttpGet("gallery")]
        public async Task<ActionResult<List<PhotoDto>>> GetPhotoGallery(int placeId)
        {
            return await _service.GetPhotoGallery(placeId);
        }

        [HttpPost("addphotostogallery")]
        public async Task<ActionResult> SetPhotoAsGalleryMember([FromBody]List<int> listOfPhotos, int placeId)
        {
            await _service.AddPhotosToSiteGallery(listOfPhotos, placeId);
            return Ok();
        }

    }
}
