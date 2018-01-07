using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();


            string input = Console.ReadLine();
            while (input != "3:1")
            {
                string[] commands = input.Split();

                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0 || startIndex > elements.Count - 1)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > elements.Count - 1)
                {
                    endIndex = elements.Count - 1;
                }

                if (command == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        Console.WriteLine(string.Join("", elements[i]));
                    }
                }

            }


            input = Console.ReadLine();
        }

    }
}

