using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(i => i.Trim()).ToList();
            var lettersRegex = new Regex(@"[^0-9+\-*\/\.]");
            var demons = new SortedDictionary<string, List<double>>();
            FillDemonsNames(demons, input);
         
            foreach (var demon in demons)
            {
                var healthSum = 0.0;
                var letterMatches = lettersRegex.Matches(demon.Key);
                foreach (Match match in letterMatches)
                {
                    var matchChar = match.Value.ToCharArray();
                    healthSum += matchChar[0];
                }
                demons[demon.Key].Add(healthSum);
            }
      
            var numbersRegex = new Regex(@"([-+]?[0-9]*\.[0-9]+|[0-9]+)|([-+]?[0-9]+)");
            var operandsRegex = new Regex(@"[\/*]");
            foreach (var demon in demons)
            {
                var damageSum = 0.0;
                var numbersMatches = numbersRegex.Matches(demon.Key);
                foreach (Match match in numbersMatches)
                {
                    double num;
                    var number = match.Value.ToString();
                    if (double.TryParse(number, out num))
                    {
                        damageSum += num;
                    }
                }
                var operandsMatches = operandsRegex.Matches(demon.Key);
                foreach (Match match in operandsMatches)
                {
                    var operand = match.Value.ToString();
                    if (operand == "*")
                    {
                        damageSum *= 2;
                    }
                    else if (operand == "/")
                    {
                        damageSum /= 2;
                    }
                }
                demons[demon.Key].Add(damageSum);
            }
        
            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }


        private static void FillDemonsNames(SortedDictionary<string, List<double>> demons, List<string> input)
        {
            foreach (var demon in input)
            {
                demons[demon] = new List<double>();
            }
        }
    }
}
