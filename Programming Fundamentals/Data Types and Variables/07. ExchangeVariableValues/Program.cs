using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Before:");
                Console.WriteLine($"a = {num1}");
                Console.WriteLine($"b = {num2}");
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("After:");
                Console.WriteLine($"a = {num2}");
                Console.WriteLine($"b = {num1}");
            }
           
        }
    }
}
