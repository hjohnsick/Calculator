using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculations
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            double answer = Math.Round((x / y), 4);
            return answer;
        }

        public static double AverageOfFourNumbers(double num1, double num2, double num3, double num4)
        {
            double sum = num1 + num2 + num3 + num4;

            return sum / 4;
        }

        public static double FindMaxNum(double num1, double num2, double num3)
        {

            List<double> numbers = new List<double>
            {
                num1, num2, num3
            };

            return numbers.Max();
        }

        public static double FindMinNum(double num1, double num2, double num3)
        {
            List<double> numbers = new List<double>
            {
                num1, num2, num3
            };

            return numbers.Min();
        }

    }
}
