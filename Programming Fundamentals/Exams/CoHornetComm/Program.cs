using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoHornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcast = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs.Length != 2)
                {
                    continue;
                }

                if (inputArgs[0].ToCharArray().All(c => Char.IsDigit(c)) &&
                    inputArgs[1].ToCharArray().All(c => Char.IsLetterOrDigit(c)))
                {
                    messages.Add($"{string.Join("", inputArgs[0].ToCharArray().Reverse())} -> {inputArgs[1]}");
                }

                if (!inputArgs[0].ToCharArray().Any(c => Char.IsDigit(c)) &&
                    inputArgs[1].ToCharArray().All(c => Char.IsLetterOrDigit(c)))
                {
                 StringBuilder sb = new StringBuilder();

                    foreach (Char c in inputArgs[1].ToCharArray())
                    {
                        if (Char.IsLower(c))
                        {
                            sb.Append(Char.ToUpper(c));
                            continue;
                        }

                        if (Char.IsUpper(c))
                        {
                            sb.Append(Char.ToUpper(c));
                            continue;
                        }
                        sb.Append(c);
                    }
                    broadcast.Add($"{sb.ToString()} -> {inputArgs[0]}");
                }
            }

            Console.WriteLine("Broadcasts:");
            PrintCollention(broadcast);
            Console.WriteLine("Messages:");
            PrintCollention(messages);


        }

        public static void PrintCollention(List<string> collection)
        {
            if (collection.Count != 0)
            {
                foreach (var current in collection)
                {
                    Console.WriteLine(current);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

           
        }
    }
}
