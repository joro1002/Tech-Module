using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            numbers.Sort();

            int count = int.Parse(Console.ReadLine());

            List<int> resultNumbers = new List<int>();

            for (int i = numbers.Count - 1 ; i >= numbers.Count - count; i--)
            {
                resultNumbers.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ",resultNumbers));
        }
    }
}
