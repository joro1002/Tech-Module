using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> ips = new SortedDictionary<string, SortedDictionary<string, int>>();
            string input = Console.ReadLine();

            for (int i = 0; i < number; i++)
            {
                string[] parametars = input.Split(' ');

                string ip = parametars[0];
                string user = parametars[1];
                int duration = int.Parse(parametars[2]);

                if (!ips.ContainsKey(user))
                {
                    ips.Add(user, new SortedDictionary<string, int>());
                }
                if (!ips[user].ContainsKey(ip))
                {
                    ips[user][ip] = 0;
                }
                ips[user][ip] += duration;
                input = Console.ReadLine();
            }
            foreach (var userName in ips)
            {
                var sum = userName.Value.Values.Sum();

                Console.Write("{0}: {1} ", userName.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", userName.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
