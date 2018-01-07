using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isOk = true;
            int start = command[1];
            int end = command[0];

            for (int i = start; i < end; i++)
            {
                if (input[i] == command[2])
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
