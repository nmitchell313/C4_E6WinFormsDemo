//Nicholas Mitchell nmitchell11@cnm.edu
// Car Inventory Demo

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleInventory
{
    public partial class VehicleInventoryForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public VehicleInventoryForm()
        {
            InitializeComponent();
        }

        private void tabNewVehicle_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "Sedan")
            {
                Sedan sedan = new Sedan();
                sedan.LicensePlate = txbLicense.Text;
                sedan.VIN = txbVIN.Text;
                vehicles.Add(sedan);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added sedan";
            }
            else if (cbType.Text == "Truck")
            {
                Truck truck = new Truck(txbVIN.Text, txbLicense.Text);
                vehicles.Add(truck);
                //Refresh the list box
                lbInventory.DataSource = null;
                lbInventory.DataSource = vehicles;
                txbResults.Text = "Successfuly added truck";
            }

        }

        private void lbInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle vehicle = (Vehicle)lbInventory.SelectedItem;
            txbSummary.Text = vehicle.GetDescription();

        }
    }
}
