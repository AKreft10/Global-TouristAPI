using DatabaseTest.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Services.ApiDataServices
{
    public class BingMapsDistanceService : IBingMapsDistanceService
    {
        private readonly IConfiguration _configuration;

        public BingMapsDistanceService(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<TimeAndDistanceDto> GetTimeAndDistance(CoordinatesDto accommodationCords, CoordinatesDto placeCoords)
        {
            var key = _configuration.GetValue<string>("BingMapsKey");
            var lat1 = placeCoords.Latitude.ToString().Replace(',', '.');
            var lon1 = placeCoords.Longitude.ToString().Replace(',', '.');

            var lat2 = accommodationCords.Latitude.ToString().Replace(',', '.');
            var lon2 = accommodationCords.Longitude.ToString().Replace(',', '.');

            var jsonUrl = $"https://dev.virtualearth.net/REST/v1/Routes/DistanceMatrix?origins={lat1},{lon1};{lat2},{lon2}&travelMode=driving&key={key}";

            var client = new HttpClient();
            var response = await client.GetAsync(jsonUrl);
            var cont = await response.Content.ReadAsStringAsync();

            var content = JsonConvert.DeserializeObject<Rootobject>(cont);

            TimeAndDistanceDto timeAndDistance = new()
            {

                Distance = Math.Round((double)content.resourceSets[0].resources[0].results[0].travelDistance, 2),
                Time = Math.Round((double)content.resourceSets[0].resources[0].results[0].travelDuration)
            };

            return timeAndDistance;
        }
    }
}
