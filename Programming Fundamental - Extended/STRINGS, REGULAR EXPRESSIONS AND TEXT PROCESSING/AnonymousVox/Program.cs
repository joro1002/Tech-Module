using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            var placeholders = Console.ReadLine().Split(new[] {'{', '}'}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "([a-zA-Z]+)(.*)(\\1)";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(encodedText);


            int count = 0;
            foreach (Match match in matchCollection)
            {
                string newValue = match.Groups[1] + placeholders[count++] + match.Groups[3];
                encodedText = encodedText.Replace(match.Value, newValue);
            }
            Console.WriteLine(encodedText);
        }
    }
}
