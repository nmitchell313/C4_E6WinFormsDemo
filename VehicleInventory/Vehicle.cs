﻿//Nicholas Mitchell nmitchell11@cnm.edu
// Car Inventory Demo


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        public abstract int Wheels { get; }
        public abstract int MaxPassengers { get; }
        public abstract string GetDescription();

    }
}
