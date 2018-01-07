using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse()
                    .ToArray())))
                .Sum();


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
