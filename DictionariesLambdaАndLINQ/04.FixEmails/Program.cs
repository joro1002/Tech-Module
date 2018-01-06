using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)

        {
            string name = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine().ToLower();
                string ending = email.Substring(email.Length - 2, 2).ToLower();

                if (ending != "uk" && ending != "us")
                {
                    dict.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
