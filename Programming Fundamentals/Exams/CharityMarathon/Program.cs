using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = double.Parse(Console.ReadLine());
            var numOfRunners = double.Parse(Console.ReadLine());
            var averageLaps = double.Parse(Console.ReadLine());
            var trackLength = double.Parse(Console.ReadLine()); 
            var trackCapacity = double.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var maxRunners = trackCapacity * marathonDays;

            if (numOfRunners >= maxRunners)
            {
                numOfRunners = maxRunners;
            }
            var totalMeters = numOfRunners * averageLaps * trackLength;
            var totalKilometers = totalMeters / 1000;
            var totalMoneyRaised = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}
