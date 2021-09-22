using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    
   
    class Program
    {
        delegate void DelegateCal(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            Calculator cal = new Calculator(x, y);
            DelegateCal newOps = cal.Add;
            newOps += cal.Subtract;
            newOps += cal.Multiply;
            newOps += cal.Divide;

            newOps.Invoke(x, y);


            Console.ReadLine();


        }
    }
}
