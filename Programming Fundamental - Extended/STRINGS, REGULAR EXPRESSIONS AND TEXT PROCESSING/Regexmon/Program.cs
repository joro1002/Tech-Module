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

            string bojoPattern = "[a-zA-Z]+\\-[a-zA-Z]+";
            string didiPattern = "[^a-zA-Z\\-]+";

            Regex regexBojo = new Regex(bojoPattern);
            Regex regexDidi = new Regex(didiPattern);

            while (true)
            {
             
                Match matchDidi = regexDidi.Match(input);

                if (matchDidi.Success)
                {
                    Console.WriteLine(matchDidi.Value);
                    input = input.Substring(input.IndexOf(matchDidi.Value) + matchDidi.Value.Length);
                }
                else
                {
                    break;
                }

                Match matchBojo = regexBojo.Match(input);

                if(matchBojo.Success)
                {
                    Console.WriteLine(matchBojo.Value);
                    input = input.Substring(input.IndexOf(matchBojo.Value) + matchBojo.Value.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
