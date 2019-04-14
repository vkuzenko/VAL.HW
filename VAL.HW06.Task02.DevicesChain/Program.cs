using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task02.DevicesChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator generator = new Generator() { GeneratedPower = 900 };
            ConsumptionDevice device01 = new ConsumptionDevice() { ConsumptionPower = 200 };
            ConsumptionDevice device02 = new ConsumptionDevice() { ConsumptionPower = 200 };
            ConsumptionDevice device03 = new ConsumptionDevice() { ConsumptionPower = 200 };
            ConsumptionDevice device04 = new ConsumptionDevice() { ConsumptionPower = 200 };
            ConsumptionDevice device05 = new ConsumptionDevice() { ConsumptionPower = 200 };
            ConsumptionDevice device06 = new ConsumptionDevice() { ConsumptionPower = 200 };

            generator.PlugDevice(device01);
            device01.PlugDevice(device02);
            device02.PlugDevice(device03);
            device03.PlugDevice(device04);
            device04.PlugDevice(device05);
            device05.PlugDevice(device06);

            Console.WriteLine($"Chain: {generator.ChainList}");

            device02.UnplugDevice();

            Console.WriteLine($"Chain: {generator.ChainList}");

            Console.ReadLine();
        }
    }
}
