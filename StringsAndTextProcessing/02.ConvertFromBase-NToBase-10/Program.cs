using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger baseValue = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            int power = 0;
            BigInteger currentNum = 0;

            while (number > 0)
            {
                int mostRightDigit = (int)(number % 10);
                currentNum = mostRightDigit * BigInteger.Pow(baseValue, power);
                number = number / 10;
                power++;
                result += currentNum;
            }

            Console.WriteLine(result);
        }
    }
}
