using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Geometry
    {
        public static double AreaOfASquare(double side)
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        public static double AreaOfARectangle(double length, double height)
        {
            double area = length * height;
            return area;
        }

        public static double AreaOfTriangle(double length, double height)
        {
            double area = (length * height) / 2;
            return area;
        }
    }
}
