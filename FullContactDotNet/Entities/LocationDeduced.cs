using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullContactDotNet.Entities
{
    public class LocationDeduced
    {
        public string NormalizedLocation { get; set; }
        public string DeducedLocation { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public Continent Continent { get; set; }
        public County County { get; set; }
        public int Likelihood { get; set; }
    }
}
