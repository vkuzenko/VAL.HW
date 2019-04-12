using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = 0;
            int ram = 0;

            List<ElectronicDevice> electronicDevices = new List<ElectronicDevice>
            {
                new ComputerNotebook("Lenovo", 20, 4, 2),
                new ComputerNotebook("Asus", 22, 2, 3),
                new ComputerServer("IBM", 300, 32, 4),
                new ComputerServer("HP", 500, 64, 8),
                new Player("Pioneer", 10, new string[] { "mp3", "mp4", "dvd" }),
                new Player("LG", 10, new string[] { "mp3", "mp4", "dvd", "acc", "flac", "jpg" }),
                new TVLCD("LG", 10, "FullHD"),
                new TVLCD("Sony", 15, "HD"),
                new TVCRT("Berezka", 250, 40),
                new TVCRT("KVN", 32, 20)
            };

            foreach (var device in electronicDevices)
            {
                Console.WriteLine(device.ToString());

                power = power + device.Power;

                Computer castedComputer = device as Computer;
                if (castedComputer != null)
                {
                    ram = ram + castedComputer.RAM;
                }                
            }

            Console.WriteLine($"Total power: {power}");
            Console.WriteLine($"Total RAM: {ram}");

            Console.ReadLine();

        }
    }
}
