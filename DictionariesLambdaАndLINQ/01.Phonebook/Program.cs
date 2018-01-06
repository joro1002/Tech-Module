using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

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
                else
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
                input = Console.ReadLine();
            }
        }
    }
}
