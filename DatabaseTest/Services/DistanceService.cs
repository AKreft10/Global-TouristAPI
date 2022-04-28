using DatabaseTest.Entity;
using DatabaseTest.Models;
using DatabaseTest.Services.ApiDataServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services
{
    public class DistanceService : IDistanceService
    {
        private readonly DatabaseContext _context;
        private readonly IBingMapsDistanceService _bingMapsService;

        public DistanceService(DatabaseContext context, IBingMapsDistanceService bingMapsService)
        {
            _context = context;
            _bingMapsService = bingMapsService;
        }

        public async Task<IList<KeyValuePair<string, TimeAndDistanceDto>>> GetTheNearestAccommodations(int id)
        {
            var coordinates = await GetCoordinates(id);
            var country = await GetCountry(id);

            var accommodationlist = await GetAllAccommodationsByCountry(country);
            var accommodationListWithDistancesAndTime = await CalculateHotelsDistance(accommodationlist, coordinates);

            return accommodationListWithDistancesAndTime;
        }

        private async Task<CoordinatesDto> GetCoordinates(int id)
        {
            var place = await _context
                .Places
                .FirstOrDefaultAsync(a => a.Id == id);

            var address = await _context
                .Addresses
                .FirstOrDefaultAsync(a => a.Id == place.AddressId);

            CoordinatesDto coords = new CoordinatesDto()
            {
                Latitude = address.Latitude,
                Longitude = address.Longitude
            };

            return coords;
        }

        private async Task<string> GetCountry(int id)
        {
            var place = await _context
                .Places
                .FirstOrDefaultAsync(a => a.Id == id);

            var country = place.Address.Country;

            return country;
        }

        private async Task<IList<KeyValuePair<string, TimeAndDistanceDto>>> CalculateHotelsDistance(List<Accommodation> accommodations, CoordinatesDto placeCoords)
        {
            IList<KeyValuePair<string, TimeAndDistanceDto>> distancesList = new List<KeyValuePair<string, TimeAndDistanceDto>>();

            foreach (var accommodation in accommodations)
            {
                var accommodationCords = new CoordinatesDto()
                {
                    Longitude = accommodation.Address.Longitude,
                    Latitude = accommodation.Address.Latitude
                };

                var distance = await _bingMapsService.GetTimeAndDistance(accommodationCords, placeCoords);
                distancesList.Add(new KeyValuePair<string, TimeAndDistanceDto>(accommodation.Name, distance));
            }

            IList<KeyValuePair<string, TimeAndDistanceDto>> orderedList = distancesList
                .OrderBy(x => x.Value.Time)
                .ToList();

            return orderedList;
        }

        private async Task<List<Accommodation>> GetAllAccommodationsByCountry(string country)
        {
            var hotels = await _context
                .Accommodations
                .Include(ad => ad.Address)
                .Where(a => a.Address.Country.ToLower() == country.ToLower())
                .ToListAsync();

            return hotels;
        }

    }
}
