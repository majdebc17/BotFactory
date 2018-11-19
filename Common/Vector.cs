using BotFactory.Interface;
using System;

namespace Common.Tools
{
    public class Vector: IVector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static Vector FromCoordinates(Coordinates begin, Coordinates end)
        {
            Vector vector = new Vector();
            double X = end.X - begin.X;
            double Y = end.Y - begin.Y;

            return vector;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
