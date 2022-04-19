using DatabaseTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public interface IPlaceService
    {
        List<Place> GetAllPlaces();
        Place GetSinglePlace(int id);
    }
}
