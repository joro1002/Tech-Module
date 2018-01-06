using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().ToLower();

            int value;

            if (int.TryParse(line, out value))
            {
                Console.WriteLine("digit");
            }
            else if (line == "a" || line == "e" || line == "i" || line == "o" || line == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
