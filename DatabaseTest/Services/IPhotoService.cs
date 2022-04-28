using DatabaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public interface IPhotoService
    {
        Task<List<PhotoDto>>GetAllPhotos(int id);
        Task<List<PhotoDto>> GetPhotoGallery(int id);
        Task AddPhotosToSiteGallery(List<int> photos, int id);
        Task SetPhotoAsAThumbnail(int photoId, int id);
    }
}
