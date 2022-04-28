using AutoMapper;
using DatabaseTest.Entity;
using DatabaseTest.Exceptions;
using DatabaseTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public PhotoService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddPhotosToSiteGallery(List<int> photos, int id)
        {
           //to do
        }

        public async Task<List<PhotoDto>> GetAllPhotos(int id)
        {
            var photos = await _context
                .PlacePhotos
                .Where(p => p.PlaceId == id)
                .Select(ph => ph.Photo)
                .ToListAsync();

            if(photos is null)
            {
                throw new NotFoundException("No photos here yet.. ):");
            }

            var result = _mapper.Map<List<PhotoDto>>(photos);

            return result;
        }

        public async Task<List<PhotoDto>> GetPhotoGallery(int id)
        {
            var photoGallery = await _context
                .PlacePhotos
                .Where(p => p.PlaceId == id)
                .Select(ph => ph.Photo)
                .Where(z => z.GalleryMember == true)
                .ToListAsync();

            if(photoGallery is null)
            {
                throw new NotFoundException("No photos here yet.. ):");
            }

            var result = _mapper.Map<List<PhotoDto>>(photoGallery);

            return result;
        }

        public Task SetPhotoAsAThumbnail(int photoId, int id)
        {
            //to do
            return Task.CompletedTask;
        }
    }
}
