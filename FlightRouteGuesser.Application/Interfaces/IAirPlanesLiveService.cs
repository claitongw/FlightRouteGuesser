using FlightRouteGuesser.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRouteGuesser.Application.Interfaces
{
    public interface IAirPlanesLiveService
    {
        Task<ICAODTO> GetFlightDataByICAOAsync(string ICAO);
    }
}
