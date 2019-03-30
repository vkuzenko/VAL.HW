using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW04.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerNotebook compNotebook01 = new ComputerNotebook("Lenovo", 20, 4, 2);
            Console.WriteLine(compNotebook01.GetDescription());
            ComputerNotebook compNotebook02 = new ComputerNotebook("Asus", 22, 2, 3);
            Console.WriteLine(compNotebook02.GetDescription());

            ComputerServer compServer01 = new ComputerServer("IBM", 300, 32, 4);
            Console.WriteLine(compServer01.GetDescription());
            ComputerServer compServer02 = new ComputerServer("HP", 500, 64, 8);
            Console.WriteLine(compServer02.GetDescription());

            Player player01 = new Player("Pioneer", 10, new string[] {"mp3", "mp4", "dvd"});
            Console.WriteLine(player01.GetDescription());
            Player player02 = new Player("LG", 10, new string[] { "mp3", "mp4", "dvd", "acc", "flac", "jpg" });
            Console.WriteLine(player02.GetDescription());

            TVLCD tvLCD01 = new TVLCD("LG", 10, "FullHD");
            Console.WriteLine(tvLCD01.GetDescription());
            TVLCD tvLCD02 = new TVLCD("Sony", 15, "HD");
            Console.WriteLine(tvLCD02.GetDescription());

            TVCRT tvCRT01 = new TVCRT("Berezka", 250, 40);
            Console.WriteLine(tvCRT01.GetDescription());
            TVCRT tvCRT02 = new TVCRT("KVN", 32, 20);
            Console.WriteLine(tvCRT02.GetDescription());

            Console.ReadLine();

        }
    }
}
