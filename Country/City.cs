using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    internal class City
    {
        public string CityName { get; set; }
        public long CityPopulation { get; set; }

        public City(string cityName, long cityPopulation)
        {
            CityName = cityName;
            CityPopulation = cityPopulation;
        }
    }
}
