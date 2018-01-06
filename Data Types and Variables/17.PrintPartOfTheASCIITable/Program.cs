using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            for (int i = 60; i <= 65; i++)
            {
                if (firstNumber >= 60 && secondNumber <= 65)
                {
                    Console.Write($"{(char)i} ");
                }
                
            }

            for (int i1 = 69; i1 <= 79; i1++)
            {
                if (firstNumber >= 69 && secondNumber <= 79)
                {
                    Console.Write($"{(char)i1} ");
                }



            }
            for (int i2 = 97; i2 <= 104; i2++)
            {
                if (firstNumber >= 97 && secondNumber <= 104)
                {
                    Console.Write($"{(char)i2} ");

                }


            }

            for (int i3 = 40; i3 <= 55; i3++)
            {
                if (firstNumber >= 40 && secondNumber <= 55)
                {
                    Console.Write($"{(char)i3} ");
                }

            }



        }
    }
}
