using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using car_traffic_simulation.objects;

namespace car_traffic_simulation.spawners
{
    public class VehicleSpawner
    {
        public List<Car> Vehicles { get; set; }

        public VehicleSpawner()
        {
            Vehicles = new List<Car>();
        }

        public void GenerateCar(int x, int y, int velocity, int height, int width)
        {
            Vehicles.Add(new Car(x, y, velocity, height, width));
        }
    }
}
