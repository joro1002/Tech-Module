using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            long P = long.Parse(Console.ReadLine());

            double distance = (N / 1000) * M;
            double times = N / 100;
            double fiveSeconds = (N / P) * 5;
            double total = times + fiveSeconds;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{total} s.");


        }
    }
}
