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

            InitializeHardcodedCars();
        }

        private void TurnOnDoubleBuffering()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void InitializeHardcodedCars()
        {
            VehicleSpawner.GenerateCar(-70, 295, 3, 35, 70, Action.MoveForward);
            VehicleSpawner.GenerateCar(800, 180, 1, 35, 70, Action.MoveBackward);

            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                this.Controls.Add(vehicle.image);
            }
        }

        private void RemoveAllHardcodedCars()
        {
            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                this.Controls.Remove(vehicle.image);
            }
            VehicleSpawner.Vehicles.Clear();
            VehicleSpawner.CurrentVehicleInfoIndex = 0;
        }

        public void RedrawVehicles(PaintEventArgs e)
        {
            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                vehicle.image.BringToFront();
                vehicle.Draw(e);
            }
        }

        public void UpdateVehicles()
        {
            foreach (var vehicle in VehicleSpawner.Vehicles)
            {
                vehicle.act();

                if (vehicle.X >= this.Width && vehicle.X <= this.Width)
                {
                    this.Controls.Remove(vehicle.image);
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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.redrawer.Start();   
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            this.redrawer.Stop();
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            this.redrawer.Stop();

            RemoveAllHardcodedCars();
            InitializeHardcodedCars();

            this.redrawer.Start();
        }
    }
}
