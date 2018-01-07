using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
               

            string temp = input[input.Length  - 1];

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }

            input[0] = temp;
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
