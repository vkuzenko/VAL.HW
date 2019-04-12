using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task02.DevicesChain
{

    internal class Variables
    {
        public static int Id = 0;
    }


    internal class ElectricDevice
    {
        public int Id { get; private set; }
        public ElectricDevice NextDevice { get; set; }

        public ElectricDevice()
        {
            this.Id = Variables.Id++;
        }

        public bool PlugDevice(ConsumptionDevice device)
        {
            Console.Write($"Plugging device {device.Id}({device.ConsumptionPower}W) to {this.Id}({AvailablePower}W)... ");
            if (this.NextDevice != null || AvailablePower < device.ConsumptionPower)
            {
                Console.WriteLine($"Failed");
                return false;
            }
            this.NextDevice = device;
            device.PreviousDevice = this;
            Console.WriteLine($"Ok");
            return true;
        }

        public virtual bool UnplugDevice()
        {
            if (this.NextDevice == null)
            {
                return false;
            }
            Console.WriteLine($"Unplugging device {this.NextDevice.Id.ToString()} from {this.Id}... Ok");
            this.NextDevice.UnplugDevice();
            this.NextDevice = null;
            return true;
        }

        public virtual int AvailablePower { get; }

        public string ChainList
        {
            get
            {
                if (this.NextDevice == null)
                {
                    return this.Id.ToString();
                }
                return this.Id.ToString() + " - " + this.NextDevice.ChainList;
            }
        }
    }


    internal class Generator : ElectricDevice
    {
        public int GeneratedPower { get; set; }

        public override int AvailablePower
        {
            get
            {
                return this.GeneratedPower;
            }
        }
    }


    internal class ConsumptionDevice : ElectricDevice
    {
        public int ConsumptionPower { get; set; }
        public ElectricDevice PreviousDevice { get; set; }

        public override int AvailablePower
        {
            get
            {
                if (PreviousDevice == null)
                {
                    return 0;
                }
                return PreviousDevice.AvailablePower - this.ConsumptionPower;
            }
        }

    }


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
