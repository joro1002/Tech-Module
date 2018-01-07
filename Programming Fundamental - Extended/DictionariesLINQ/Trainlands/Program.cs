using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();
            string[] splitters = { " -> ", " : ", " = " };
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "It's Training Men!")
                {
                    break;
                }

                string[] data = input.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

                if (input.Contains(":"))
                {
                    if (!trains.ContainsKey(data[0]))
                    {
                        trains.Add(data[0], new Dictionary<string, int>(){
                            {data[1], int.Parse(data[2])}
                    });
                    }
                    else
                    {
                        trains[data[0]].Add(data[1], int.Parse(data[2]));
                    }
                }
                else if (input.Contains("->"))
                {
                    string trainName = data[0];
                    string otherTrainName = data[1];
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    foreach (var wagon in trains[otherTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                    trains.Remove(otherTrainName);
                }
                else if (input.Contains("="))
                {
                    string trainName = data[0];
                    string otherTrainName = data[1];
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }
                    trains[trainName].Clear();
                    foreach (var wagon in trains[otherTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                }
            }

            var sorted = trains.OrderByDescending(t => t.Value.Values.Sum()).ThenBy(t => t.Value.Count);

            foreach (var train in sorted)
            {
                Console.WriteLine($"Train: {train.Key}");
                var reversed = train.Value.OrderBy(w => w.Value).Reverse();
                foreach (var wagon in reversed)
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
