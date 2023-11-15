﻿//Nicholas Mitchell nmitchell11@cnm.edu
// Car Inventory Demo


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    class Truck:Vehicle
    {
        public Truck(string vin, string license)
        {
            VIN = vin;
            LicensePlate = license;
        }

        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 3;
            }
        }

        public override string ToString()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN " + VIN;
        }

        public override string GetDescription()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }

    }
}
