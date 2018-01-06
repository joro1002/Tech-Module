using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool numberTRUE = true;
                for (int currentNumber1 = 2; currentNumber1 <= Math.Sqrt(currentNumber); currentNumber1++)
                {
                    if (currentNumber % currentNumber1 == 0)
                    {
                        numberTRUE = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {numberTRUE}");
            }

            }
        }
}
