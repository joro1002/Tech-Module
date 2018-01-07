using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secontPerPicture = long.Parse(Console.ReadLine());
            long filter = long.Parse(Console.ReadLine());
            long uploudTimePerPicture = long.Parse(Console.ReadLine());

            long filterSecond = pictures * secontPerPicture;
            long filteredPics = (long)Math.Ceiling(filter * pictures / 100.0);
            long uploadSeconds = filteredPics * uploudTimePerPicture;
            long totalSeconds = filterSecond + uploadSeconds;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);


        }
    }
}
