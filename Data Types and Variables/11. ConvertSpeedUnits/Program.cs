using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeSeconds = hours * 3600 + minutes * 60 + seconds;

            float metersPerSeconds = distanceInMeters / timeSeconds;
            float metersToKm = distanceInMeters / 1000;

            float timeHours = timeSeconds / 3600;
            float killometersPerHour = metersToKm / timeHours;
            float milesPerHour = (metersToKm / 1.609f) / timeHours;

            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(killometersPerHour);
            Console.WriteLine(milesPerHour);



        }
    }
}
