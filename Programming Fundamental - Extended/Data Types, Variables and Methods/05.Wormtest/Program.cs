using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtMeters = int.Parse(Console.ReadLine());
            double wightCentimeters = double.Parse(Console.ReadLine());
            
            double convertMInSm = lenghtMeters * 100;

            if (convertMInSm % wightCentimeters == 0 || wightCentimeters == 0)
            {
                Console.WriteLine($"{convertMInSm * wightCentimeters:F2}"); 
            }
            else
            {
                double percent = convertMInSm / (wightCentimeters / 100);
                Console.WriteLine($"{percent:F2}%");
            }
        }
    }
}
