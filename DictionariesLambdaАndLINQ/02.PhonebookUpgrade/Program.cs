using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] phoneParametars = input.Split(' ');
                string command = phoneParametars[0];


                if (command == "A")
                {
                    string key = phoneParametars[1]; 
                    string value = phoneParametars[2];

                    phonebook[key] = value;
                }
                else if (command == "S")
                {
                    string key = phoneParametars[1];

                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }

                }
                else
                {
                    foreach (string entry in phonebook.Keys)
                    {
                        Console.WriteLine("{0} -> {1}", entry, phonebook[entry]);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
