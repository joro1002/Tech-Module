using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string[] sentences = text.Split(new char[] { '.', '!', '?' });

            string pattern = "\\b" + word + "\\b";
            Regex regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }

            }
        }
    }
}

