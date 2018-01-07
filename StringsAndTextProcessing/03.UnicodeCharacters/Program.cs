using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();

            foreach (var charakter in input)
            {
                string unicode = "\\u" + ((int)charakter).ToString("x4");
                sb.Append(unicode);
            }
            Console.WriteLine(sb);

        }
    }
}
