using FlightRouteGuesser.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlightRouteGuesser.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightDataController : ControllerBase
    {
        private readonly IAirPlanesLiveService _airPlanesLiveService;

        public FlightDataController(IAirPlanesLiveService airPlanesLiveService)
        {
            _airPlanesLiveService = airPlanesLiveService;
        }

        [HttpGet("{icao}")]
        public async Task<IActionResult> GetFlightDataByICAO(string icao)
        {
            var result = await _airPlanesLiveService.GetFlightDataByICAOAsync(icao);

            if (result.ac[0].alt_baro > 0)
                return Ok("Decolou");

            return Ok();
        }
    }
}
