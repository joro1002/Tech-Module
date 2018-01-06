using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (input != "stop")
            {
                if (dict.ContainsKey(input))
                {
                    dict[input] += int.Parse(Console.ReadLine());
                }
                else
                {
                    dict[input] = int.Parse(Console.ReadLine());
                }
                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
