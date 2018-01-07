using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<long> aLiveBeehive = new List<long>();

            foreach (var beehive in beehives)
            {
                if (hornets.Count == 0)
                {
                    aLiveBeehive.Add(beehive);
                    continue;

                }

                var power = hornets.Sum();

                if (power >= beehive)
                {
                    if (power == beehive)
                    {
                        hornets.RemoveAt(0);
                    }

                }
                else
                {
                    aLiveBeehive.Add(beehive - power);
                    hornets.RemoveAt(0);
                }

            }
            if (aLiveBeehive.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aLiveBeehive));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }

    }
}
