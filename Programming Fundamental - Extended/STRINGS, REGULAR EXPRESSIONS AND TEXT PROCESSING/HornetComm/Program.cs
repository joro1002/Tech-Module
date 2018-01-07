using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string privateMessage = "^([0-9]+) <-> ([a-zA-Z0-9]+)$";
            string broadcast = "^([^0-9]+) <-> ([a-zA-Z0-9]+)$";

            Regex regexPrivateMessage = new Regex(privateMessage);
            Regex regexBroadcast = new Regex(broadcast);

            List<string> message = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                Match matchPrivateMessage = regexPrivateMessage.Match(input);
                Match matchBroadcast = regexBroadcast.Match(input);

                if (matchPrivateMessage.Success)
                {
                    string recipientsCode = matchPrivateMessage.Groups[1].ToString();
                    recipientsCode = string.Join("", recipientsCode.ToCharArray().Reverse().ToArray());
                    message.Add(recipientsCode + " -> " + matchPrivateMessage.Groups[2].ToString());
                }

                if (matchBroadcast.Success)
                {
                    string frequency = matchBroadcast.Groups[2].ToString();
                    string frequencyResult = "";
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            frequencyResult += frequency[i].ToString().ToLower();
                        }
                        else
                        {
                            frequencyResult += frequency[i].ToString();
                        }
                    }
                    broadcasts.Add(frequencyResult + " -> " + matchBroadcast.Groups[1]);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var one in broadcasts)
                {

                    Console.WriteLine(one);
                }
            }


            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var two in message)
                {
                    Console.WriteLine(two);
                }
            }

        }
    }
}
