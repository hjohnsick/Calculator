using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Fibonacci
    {
        public static int GetFibonacci(int position)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int result = 0;

            if (position == 0)
            {
                return 0;
            }
            else if (position == 1)
            {
                return 1;
            }

            for (int i = 2; i <= position; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }
    }
}
