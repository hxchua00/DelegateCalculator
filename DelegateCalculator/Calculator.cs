using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    
    class Calculator
    {
        int x, y;
       
        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Add(int x, int y)
        {
            Console.WriteLine("I'm in Calculator class, Add function.");
            Console.WriteLine("Addition: " + (x + y));
            Console.WriteLine();
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("I'm in Calculator class, Subtract function.");
            Console.WriteLine("Subtraction: " + (x - y));
            Console.WriteLine();
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("I'm in Calculator class, Multiply function.");
            Console.WriteLine("Multiplication: " + (x * y));
            Console.WriteLine();
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine("I'm in Calculator class, Divide function.");
            Console.WriteLine("Division: " + (x / y));
            Console.WriteLine();
        }
    }
}
