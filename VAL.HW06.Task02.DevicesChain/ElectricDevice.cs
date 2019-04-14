using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task02.DevicesChain
{
    internal class ElectricDevice
    {
        public int Id { get; private set; }
        public ConsumptionDevice NextDevice { get; set; }

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
            this.NextDevice.PreviousDevice = null;
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
}
