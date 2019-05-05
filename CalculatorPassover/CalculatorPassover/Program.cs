using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPassover
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool PosAdd = true;

            while(PosAdd)
            {
                Console.Write("Please choice your first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please choice your second number:");
                int y = Convert.ToInt32(Console.ReadLine());

                if(x < 1)
                {
                    PosAdd = false;
                    Console.WriteLine("You can't Add 0 or negative numbers ");
                }
                else
                {
                    calculator.AddNumbers(x, y);
                    Console.WriteLine("Your numbers Added ");
                }
            }
            Console.WriteLine("Result of Calculator");
            calculator.PrintCalculator();

        }
    }
}
