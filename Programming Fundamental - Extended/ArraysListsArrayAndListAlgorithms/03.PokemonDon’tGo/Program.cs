using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            long sumOfAllRemoved = 0;
            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int currentValue = 0;

                if (index < 0)
                {
                    currentValue = numbers[0];
                    sumOfAllRemoved += currentValue;
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (index > numbers.Count - 1)
                {
                    currentValue = numbers[numbers.Count - 1];
                    sumOfAllRemoved += currentValue;
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    currentValue = numbers[index];
                    sumOfAllRemoved += currentValue;
                    numbers.RemoveAt(index);
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= currentValue)
                    {
                        numbers[i] += currentValue;
                    }
                    else
                    {
                        numbers[i] -= currentValue;
                    }
                   
                }
            }
            Console.WriteLine(sumOfAllRemoved);
        }
      
    }
}
