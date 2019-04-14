using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task02.DevicesChain
{
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
}
