using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> database = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(new string[] { "=", " " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> ipsWithCounts = new Dictionary<string, int>();

            while (!input[0].Equals("end"))
            {
                string ip = input[1];
                string user = input[input.Length - 1];

                if (!database.ContainsKey(user))
                {
                    database.Add(user, new Dictionary<string, int>());
                    database[user].Add(ip, 1);
                }
                else
                {
                    if (!database[user].ContainsKey(ip))
                    {
                        database[user].Add(ip, 1);
                    }
                    else
                    {
                        database[user][ip]++;
                    }
                }

                input = Console.ReadLine().Split(new string[] { "=", " " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (string userName in database.Keys)
            {
                Console.WriteLine("{0}: ", userName);

                int count = database[userName].Count;

                foreach (string ipAddress in database[userName].Keys)
                {
                    if (count > 1)
                    {
                        Console.Write("{0} => {1}, ", ipAddress, database[userName][ipAddress]);
                    }
                    else
                    {
                        Console.WriteLine("{0} => {1}. ", ipAddress, database[userName][ipAddress]);
                    }

                    count--;
                }
            }
        }
    }
}
