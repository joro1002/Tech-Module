using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int baseValue = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            int remainder = 0;

            StringBuilder binary = new StringBuilder();

            while (number > 0)
            {
                remainder = (int)(number % baseValue);
                binary.Append(remainder);
                number = number / baseValue;
            }

            Console.WriteLine(string.Join(string.Empty, binary.ToString().ToCharArray().Reverse()));

        }
    }
}
