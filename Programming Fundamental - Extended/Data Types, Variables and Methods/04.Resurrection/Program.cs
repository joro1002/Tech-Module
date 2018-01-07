using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPhoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPhoenixes; i++)
            {
             
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWight = decimal.Parse(Console.ReadLine());
                long lenght1wing = long.Parse(Console.ReadLine());

                decimal totalYears = (totalLength * totalLength) * (totalWight + (2 * lenght1wing));

                Console.WriteLine(totalYears);

            }
           
        }
    }
}
