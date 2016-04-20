using AirlineLibrary;
using AirlineLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManager
{
    public static class AirlineFactory
    {
        public static IAirlineManager CreateManager(string[] args) {
            var countAirlineObjects = 0;
            if (args != null && args.Length > 0)
                int.TryParse(args[0], out countAirlineObjects);

            var assembly = Assembly.LoadFrom("AirlineLibrary.dll");

            var type = assembly.GetType("AirlineLibrary.Model.CityAirport");

            //return new CityAirport(countAirlineObjects);
            //return null;
            var airlineManager = Activator.CreateInstance(type, countAirlineObjects) as IAirlineManager;
            return airlineManager;
        }
    }
}
