﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int element = 0;

                if (index < 0)
                {
                    element = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }

                else if (index > numbers.Count - 1)
                {
                    element = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    element = numbers[index];
                    numbers.RemoveAt(index);
                }
                sum = sum + element;

                for (int i = 0; i < numbers.Count; i++)
                {
                    int current = numbers[i];
                    if (current <= element)
                    {
                        numbers[i] += element;
                    
                    }
                    else
                    {
                        numbers[i] -= element;
                    }
                }
               
            }
            Console.WriteLine(sum);

        }

    }
}
