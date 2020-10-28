using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class FizzBuzz
    {
        public static object PrintNumbersOrFizzBuzz(int param)
        {
            if (param < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (param % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (param % 3 == 0)
            {
                return "Fizz";
            }
            else if (param % 5 == 0)
            {
                return "Buzz";
            }
            return param;
        }
    }
}
