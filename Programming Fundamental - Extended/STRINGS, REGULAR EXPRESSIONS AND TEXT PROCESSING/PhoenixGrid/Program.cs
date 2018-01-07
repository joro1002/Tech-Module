using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^([^\s_]{3})(\.[^\s_]{3})*$";
            Regex regex = new Regex(pattern);

            while (input != "ReadMe")
            {
                if (regex.IsMatch(input))
                {
                    if (isPalindrom(input))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                    
                }
                else
                {
                    Console.WriteLine("NO");
                }




                input = Console.ReadLine();

            }
        }

        static bool isPalindrom(string word)
        {
            for (int j = 0; j < word.Length / 2; j++)
            {
                if (word[j] != word[word.Length - 1 - j] )
                {
                    return false;
                }
            }
            return true;
        }

    }
}
