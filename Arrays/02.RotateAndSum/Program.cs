using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int reminder = numbers[numbers.Length - 1];

                for (int i1 = numbers.Length - 1; i1 > 0; i1--)
                {
                    numbers[i1] = numbers[i1 - 1];
                    sum[i1] += numbers[i1];
                }
                numbers[0] = reminder;
                sum[0] += numbers[0];
            }
            Console.WriteLine($"{string.Join(" ", sum)}");
        }
        
    }
}
