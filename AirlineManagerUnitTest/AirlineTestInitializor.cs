using AirlineLibrary;
using AirlineManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Airline.AP.UnitTest
{
    public class AirlineTestInitializor
    {
        public IAirlineManager GetManager() => AirlineFactory.CreateManager(null);
        public bool HasError { get; set; }
    }
}
