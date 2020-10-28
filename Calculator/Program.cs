using Practice;
using System;

namespace Calculations
{
    class Program
    {
        //Why wouldn't you just use a regular variable
        public delegate void State(string state);
        static void Main(string[] args)
        {
            int outsideScope = 99;
            State s = delegate (string state) {
                Console.WriteLine($"The state: {state} was entered!");
                Console.WriteLine($"The value from outer scope is: {outsideScope}");
            };
            s("up");
            Console.ReadKey();
        }
    }
}
