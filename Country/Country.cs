using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Country
{
    internal class Country
    {
       public List<City>cities = new List<City>();
        public string Name { get; set; }
        public long TotalPopulation { get; set; }

         public Country(string name,long totalPopulation)
        {
            Name= name;
            TotalPopulation= totalPopulation;
        }

        public void FindAllByPopulation(long min,long max)
        {
            List<City> citys= new List<City>();
            foreach (var city in cities ) 
            {
             if(city.CityPopulation>min && city.CityPopulation<=max)
                {
                   citys.Add(city);
                    Console.WriteLine($"City Name: {city.CityName} City Population: {city.CityPopulation}");
                }
             
            }
            if ( citys.Count  == 0 ) 
            {
                Console.WriteLine($"Country Name: {Name}  Total Popilaciton: {TotalPopulation} ");
            }

        }
        }
    }

