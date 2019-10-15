using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using car_traffic_simulation.objects;

namespace car_traffic_simulation.spawners
{

    public class VehicleInfo
    {
        public String ImgUrl { get; set; }
        public RotateFlipType Rotation { get; set; }

        public VehicleInfo(String imgUrl, RotateFlipType rotation)
        {
            ImgUrl = imgUrl;
            Rotation = rotation;
        }
    };

    public class VehicleSpawner
    {
        public int CurrentVehicleInfoIndex { get; set; } = 0;

        private readonly List<VehicleInfo> vehicleInfos = new List<VehicleInfo>
        {
            new VehicleInfo("assets/blue-car.png", RotateFlipType.Rotate270FlipNone),
            new VehicleInfo("assets/green-car.png", RotateFlipType.Rotate90FlipNone)
        };

        public List<Car> Vehicles { get; set; }

        public VehicleSpawner()
        {
            Vehicles = new List<Car>();
        }

        private Image PrepareCarImage(VehicleInfo vehicleInfoIndex, int width, int height)
        {
            Image resized = new Bitmap(new Bitmap("..\\..\\" + @vehicleInfoIndex.ImgUrl), new Size(height, width));
            resized.RotateFlip(vehicleInfoIndex.Rotation);

            return resized;
        }

        public void GenerateCar(int x, int y, int velocity, int height, int width, Action action)
        {
            var car = new Car(x, y, velocity, height, width);

            car.decideAction(action);

            car.image.BackgroundImage = PrepareCarImage(vehicleInfos[CurrentVehicleInfoIndex++], width, height);

            Vehicles.Add(car);
        }
    }
}
