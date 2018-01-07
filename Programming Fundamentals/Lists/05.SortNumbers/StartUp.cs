using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.SortNumbers
{
    public class StartUp
    {
       public static void Main()
        {
            List<decimal> numbers = new List<decimal>();

            numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
