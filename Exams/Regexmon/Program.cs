using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string bojoPattern = "[a-zA-Z]+-[a-zA-Z]+";
            string didoPattern = "[^a-zA-Z\\-]+";

            Regex regexBojo = new Regex(bojoPattern);
            Regex regexDidi = new Regex(didoPattern);


            while (true)
            {
                Match didiMatch = regexDidi.Match(input);
                if (!didiMatch.Success)
                {
                    break;
                }
                Console.WriteLine(didiMatch.Value);
              
                
                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = regexBojo.Match(input);
                if (!bojoMatch.Success)
                {
                    break;
                }
                

                Console.WriteLine(bojoMatch.Value);
                

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
                
            }
        }
    }
}
