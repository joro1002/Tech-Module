using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int count = 0;
            int originalN = N;

            while (N >= M)
            {
                N -= M;
                count++;

                if (N == originalN * 0.5 && Y != 0)
                {
                    N /= Y;
                }

            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
