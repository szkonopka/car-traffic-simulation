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
    public enum Action
    {
        MoveForward,
        MoveBackward,
        TurnRight,
        TurnLeft
    };

    public class Vehicle
    {
        protected int MovementVetor;
        public Action CurrentAction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int LastX { get; set; }
        public int LastY { get; set; }
        public int Velocity { get; set; }
        public float Angle { get; set; }

        public Vehicle(int x, int y, int velocity)
        {
            X = x;
            Y = y;
            Velocity = velocity;
            MovementVetor = 0;
        }

        public virtual void Draw(PaintEventArgs e) { }

        public virtual void Draw(PaintEventArgs e, Action action) { }

        public void decideAction(Action action)
        {
            CurrentAction = action;

            switch (action)
            {
                case Action.MoveForward:
                    MovementVetor = Velocity;
                    break;
                case Action.MoveBackward:
                    MovementVetor = 0 - Velocity;
                    break;
                case Action.TurnLeft:
                    break;
                case Action.TurnRight:
                    break;
            }
        }

        public void act()
        {
            X += MovementVetor;
        }
    }
}
