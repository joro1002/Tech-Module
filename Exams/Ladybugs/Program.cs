using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new int[fieldSize];
            var bugsIndex = Console.ReadLine().Split(' ').Select(int.Parse).Where(a => a >= 0 && a < fieldSize).ToList();

            field = FillField(field, bugsIndex, fieldSize);
            var command = Console.ReadLine();
            while (command != "end")
            {
                var tokens = command.Split();
                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length) 
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (field[ladybugIndex] == 0) 
                {
                    command = Console.ReadLine();
                    continue;
                }
                MoveLadybug(field, ladybugIndex, flyLength, direction);
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", field));
        }

        private static void MoveLadybug(int[] field, int ladybugIndex, int flyLength, string direction)
        {
            field[ladybugIndex] = 0;
            var leftArrayOrFoundPlace = false;
            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "left":
                        {
                            ladybugIndex -= flyLength;
                            break;
                        }
                    case "right":
                        {
                            ladybugIndex += flyLength;
                            break;
                        }
                }
                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    leftArrayOrFoundPlace = true;
                    continue;
                }
                if (field[ladybugIndex] == 1)

                {
                    continue;
                }
                if (field[ladybugIndex] == 0) 
                {
                    field[ladybugIndex] = 1;
                    leftArrayOrFoundPlace = true;
                    continue;
                }
            }
        }

        private static int[] FillField(int[] field, List<int> bugsIndex, int fieldSize)
        {
            var fillField = new int[fieldSize];
            for (int i = 0; i < bugsIndex.Count; i++)
            {
                var current = bugsIndex[i];
                fillField[current] = 1;
            }
            return fillField;
        }
    }
}
