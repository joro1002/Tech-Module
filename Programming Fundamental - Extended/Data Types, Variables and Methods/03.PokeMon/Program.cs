qusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int originalN = (N * 50) / 100;
             
           
            int count = 0;
            while (N >= M)
            {
                N -= M;

                if (N == originalN)
                {
                    if (N > 0)
                    {
                        N /= Y;
                    }
                }
                count++;
            }
            Console.WriteLine(N);
            Console.WriteLine(count);

        }
    }
}
