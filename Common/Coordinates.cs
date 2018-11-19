using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public class Coordinates : ICoordinates
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Coordinates(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            Coordinates coordinates = (Coordinates)obj;
            return X == coordinates.X && Y == coordinates.Y;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
