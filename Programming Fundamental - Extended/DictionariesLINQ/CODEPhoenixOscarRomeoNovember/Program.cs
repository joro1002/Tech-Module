using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEPhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> creatures = new Dictionary<string, HashSet<string>>();
            List<string> check = new List<string>();

            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                string[] date = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string creature = date[0];
                string squadMate = date[1];

                check.Add(squadMate + "" + creature);

                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature, new HashSet<string>());
                }

                if (creature == squadMate || check.Contains(creature + "" + squadMate))
                {
                    creatures[squadMate].Remove(creature);
                    input = Console.ReadLine();
                    continue;
                    
                }
                creatures[creature].Add(squadMate);
                

                input = Console.ReadLine();
            }

            foreach (var item in creatures.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
