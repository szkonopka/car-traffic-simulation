using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using car_traffic_simulation.spawners;

namespace car_traffic_simulation
{
    public partial class Simulation : Form
    {
        private VehicleSpawner VehicleSpawner;

        public Simulation()
        {
            TurnOnDoubleBuffering();

            VehicleSpawner = new VehicleSpawner();

            InitializeComponent();

            VehicleSpawner.GenerateCar(0, 360, 1, 20, 60);;
            
            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                vehicle.image.BringToFront();
                this.Controls.Add(vehicle.image);
            }
        }

        private void TurnOnDoubleBuffering()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        public void RedrawVehicles(PaintEventArgs e)
        {
            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                vehicle.Draw(e);
            }
        }

        public void UpdateVehicles()
        {
            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                vehicle.X += vehicle.Velocity;
                if (vehicle.X >= this.Width)
                {
                    VehicleSpawner.Vehicles.Remove(vehicle);
                    break;
                }
            }
        }

        private void Simulation_Paint(object sender, PaintEventArgs e)
        {
            RedrawVehicles(e);
        }

        private void Redrawer_Tick(object sender, EventArgs e)
        {
            UpdateVehicles();
            
            Invalidate();
        }
    }
}
