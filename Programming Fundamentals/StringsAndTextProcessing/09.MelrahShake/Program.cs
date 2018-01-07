using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = Console.ReadLine();



            while (patern.Length > 0)
            {
                int firstIndex = input.IndexOf(patern);
                int lastIndex = input.LastIndexOf(patern);
                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    input = input.Remove(lastIndex, patern.Length);
                    input = input.Remove(firstIndex, patern.Length);
                    Console.WriteLine("Shaked it.");

                }
                else
                {
                    break;
                }
                patern = patern.Remove(patern.Length / 2, 1);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
