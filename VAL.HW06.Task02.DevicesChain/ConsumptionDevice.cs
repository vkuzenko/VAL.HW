using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task02.DevicesChain
{
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
}
