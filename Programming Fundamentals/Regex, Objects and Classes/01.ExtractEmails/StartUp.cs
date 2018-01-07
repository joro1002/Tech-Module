using System;
using System.Text.RegularExpressions;


namespace _01.ExtractEmails
{
    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(([a-zA-Z0-9._-]+)@([a-zA-Z\-]+(\.[a-z]+)+))";

            Regex regex = new Regex(pattern);

            MatchCollection mathes = regex.Matches(text);

            foreach (Match imeils in mathes)
            {
                string imeil = imeils.ToString();
                if (!(imeil.StartsWith("-") || imeil.StartsWith(".") || imeil.StartsWith("_") || imeil.EndsWith(".") || imeil.EndsWith("-")))
                {
                    Console.WriteLine(imeils);
                }
            }
        }
    }
}
