using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerNotebook CompN01 = new ComputerNotebook("Lenovo", 20, 4, 2);
            Console.WriteLine(CompN01.GetDescription());
            ComputerNotebook CompN02 = new ComputerNotebook("Asus", 22, 2, 3);
            Console.WriteLine(CompN02.GetDescription());

            ComputerServer CompS01 = new ComputerServer("IBM", 300, 32, 4);
            Console.WriteLine(CompS01.GetDescription());
            ComputerServer CompS02 = new ComputerServer("HP", 500, 64, 8);
            Console.WriteLine(CompS02.GetDescription());

            Player Player01 = new Player("Pioneer", 10, new string[] {"mp3", "mp4", "dvd"});
            Console.WriteLine(Player01.GetDescription());
            Player Player02 = new Player("LG", 10, new string[] { "mp3", "mp4", "dvd", "acc", "flac", "jpg" });
            Console.WriteLine(Player02.GetDescription());

            TVLCD TVLCD01 = new TVLCD("LG", 10, "FullHD");
            Console.WriteLine(TVLCD01.GetDescription());
            TVLCD TVLCD02 = new TVLCD("Sony", 15, "HD");
            Console.WriteLine(TVLCD02.GetDescription());

            TVCRT TVCRT01 = new TVCRT("Berezka", 250, 40);
            Console.WriteLine(TVCRT01.GetDescription());
            TVCRT TVCRT02 = new TVCRT("KVN", 32, 20);
            Console.WriteLine(TVCRT02.GetDescription());

            Console.ReadLine();

        }
    }
}
