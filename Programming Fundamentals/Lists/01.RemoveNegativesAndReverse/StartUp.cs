using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.RemoveNegativesAndReverse
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            numbers = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToList();

            if (numbers.Count > 0)
            {
                numbers.RemoveAll(i => i < 0);
                Console.WriteLine("empty");
            }
           

            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
