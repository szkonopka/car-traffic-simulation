using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace car_traffic_simulation.objects
{
    public class Car : Vehicle
    {
        public PictureBox image { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public Rectangle Rectangle { get; set; }

        public Car(int x, int y, int velocity, int height, int width) : base(x, y, velocity)
        {
            Height = height;
            Width = width;

            image = new PictureBox();

            image.Size = new Size(Width, Height);
            image.Location = new Point(X, Y);
        }

        public void Draw(PaintEventArgs e)
        {
            image.Size = new Size(Width, Height);
            image.Location = new Point(X, Y);
        }
    }
}
