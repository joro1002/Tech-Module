using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            bool isOk = true;
            int start = command[1];
            int end = command[0];
            for (int i = start; i < end; i++)
            {
                if (numbers[i] == command[2])
                {
                    Console.WriteLine("YES!");
                    isOk = false;
                }

            }
            if (isOk)
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
