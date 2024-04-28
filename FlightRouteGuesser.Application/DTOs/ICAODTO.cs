using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRouteGuesser.Application.DTOs
{
    public class ICAODTO
    {
        public List<Ac> ac { get; set; }
        public string msg { get; set; }
        public long now { get; set; }
        public int total { get; set; }
        public long ctime { get; set; }
        public int ptime { get; set; }
    }

    public class Ac
    {
        public string hex { get; set; }
        public string type { get; set; }
        public string r { get; set; }
        public string t { get; set; }
        public string desc { get; set; }
        public int alt_baro { get; set; }
        public float gs { get; set; }
        public float track { get; set; }
        public int baro_rate { get; set; }
        public string squawk { get; set; }
        public string category { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public int nic { get; set; }
        public int rc { get; set; }
        public float seen_pos { get; set; }
        public int version { get; set; }
        public int nic_baro { get; set; }
        public object[] mlat { get; set; }
        public object[] tisb { get; set; }
        public int messages { get; set; }
        public float seen { get; set; }
        public float rssi { get; set; }
    }
}