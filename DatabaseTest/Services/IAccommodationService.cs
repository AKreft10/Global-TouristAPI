using DatabaseTest.Entity;
using DatabaseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public interface IAccommodationService
    {
        Task<List<AccommodationDto>> GetAllAccommodations();
        Task<AccommodationDto> GetSingleAccomodation(int id);
        Task DeleteAccommodationById(int id);
    }
}
