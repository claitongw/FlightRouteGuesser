using FlightRouteGuesser.Application.DTOs;
using FlightRouteGuesser.Application.Interfaces;
using Newtonsoft.Json;

namespace FlightRouteGuesser.Application.Services
{
    public class AirPlanesLiveService : IAirPlanesLiveService
    {
        private readonly HttpClient _httpClient;

        public AirPlanesLiveService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ICAODTO> GetFlightDataByICAOAsync(string ICAO)
        {
            var response = await _httpClient.GetAsync("https://api.airplanes.live/v2/icao/E4925C");

            if (response != null)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ICAODTO>(responseBody);
            }

            return new ICAODTO();
        }
    }
}