using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int startIndex = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int subtract = 1;

            while (input != "Supernova")
            {
                string[] commands = input.Split();
                string direction = commands[0];
                int steps = int.Parse(commands[1]);

                if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex == 0)
                        {
                            startIndex = numbers.Count - 1;
                            subtract++;
                            numbers[startIndex] -= subtract;
                            continue;
                        }

                        startIndex--;
                        numbers[startIndex] -= subtract;

                    }

                }
                if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex == numbers.Count - 1)
                        {
                            startIndex = 0;
                            subtract++;
                            numbers[startIndex] -= subtract;
                            continue;
                        }

                        startIndex++;
                        numbers[startIndex] -= subtract;

                    }

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

