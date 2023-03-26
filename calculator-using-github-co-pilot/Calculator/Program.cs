using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculator!, built using github co-pilot");

            var calculator = new Calculator.Domain.Calculator();
            Console.WriteLine("Lets add 1 and 2");
            var result = calculator.Add(1, 2);
            Console.WriteLine($"The result is {result}");
        }
    }
}