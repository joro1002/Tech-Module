using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int product = CharMultiplier(input);
            Console.WriteLine(product);

        }

        public static int CharMultiplier(string inputString)
        {
            string[] strings = inputString.Split();
            string firstString = strings[0];
            string secondsString = strings[1];
            int lenght = Math.Max(firstString.Length, secondsString.Length);

            int result = 0;

            for (int i = 0; i < lenght; i++)
            {
                int firstStrCharASCIIcode = 1;
                int secondStrCharASCIIcode = 1;
                if (i < firstString.Length)
                {
                    firstStrCharASCIIcode = firstString[i];

                }
                if (i < secondsString.Length)
                {
                    secondStrCharASCIIcode = secondsString[i];
                }

                result += firstStrCharASCIIcode * secondStrCharASCIIcode;
            }
            return result;
        }
    }
}
