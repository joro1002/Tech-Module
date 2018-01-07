using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                var command = input
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "add")
                {
                   numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }

                else if (command[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(command[1]), command.Skip(2).Select(int.Parse).ToArray());

                }
                else if (command[0] == "contains")
                {
                    int number = int.Parse(command[1]);
                    Console.WriteLine(numbers.IndexOf(number));
                }
                else if (command[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    int number = int.Parse(command[1]);
                    number = number % numbers.Count;
                    var rem = numbers.Take(number).ToList();
                    numbers.RemoveRange(0, number);
                    numbers.AddRange(rem);
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
