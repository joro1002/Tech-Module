using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(number))
                {
                    Console.WriteLine("yes");
                    break;
                }
                else
                {
                    Console.WriteLine("no");
                    break;
                }
            }
        }
    }
}
