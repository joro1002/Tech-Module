using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int affectedWebsitesCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0;

            for (int i = 0; i < affectedWebsitesCount; i++)
            {
                string[] websites = Console.ReadLine().Split();
                string sityName = websites[0];
                decimal sityVisits = decimal.Parse(websites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websites[2]);

                decimal siteLoss = sityVisits * siteCommercialPricePerVisit;
                totalLoss = totalLoss + siteLoss;

                Console.WriteLine(sityName);


            }
           
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, affectedWebsitesCount)}");

        }
    }
}
