using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

           
            double distanceTravelled = (wingFlaps / 1000) * distance;
        
            Console.WriteLine($"{distanceTravelled:F2} m.");

            double timeOfBrakes = wingFlaps / endurance * 5;
            double timeTravelled = wingFlaps / 100;

            Console.WriteLine($"{timeOfBrakes + timeTravelled} s.");

        }
    }
}
