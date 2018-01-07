using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] curentCommand = Console.ReadLine().Split();


                if (curentCommand[0] == "Odd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    break;
                }
                if (curentCommand[0] == "Even")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    break;
                }

                if (curentCommand[0] == "Delete")
                {
                    int number = int.Parse(curentCommand[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }
                    }
                }
                if (curentCommand[0] == "Insert")
                {
                    int element = int.Parse(curentCommand[1]);
                    int position = int.Parse(curentCommand[2]);

                  
                        numbers.Insert(position, element);
                    
                }
            }
        }
    }
}
