using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[[^a-zA-Z0-9]*\]\.)(\.\[[a-zA-Z0-9]*\]\.)*$";

            Regex regex = new Regex(pattern);
          
            while (input != "Traincode!")
            {
                if (regex.IsMatch(input))
                {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
          
        }
    }
}
