using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_traffic_simulation
{
    public struct Action
    {
        public bool moveRight;
        public bool moveLeft;
        public bool moveForward;
        public bool moveBackward;
    }

    public class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int LastX { get; set; }
        public int LastY { get; set; }
        public int Velocity { get; set; }

        public Vehicle(int x, int y, int velocity)
        {
            X = x;
            Y = y;
            Velocity = velocity;
        }

        public virtual void Draw(PaintEventArgs e) { }
        public virtual void Draw(PaintEventArgs e, Action action) { }
    }
}
