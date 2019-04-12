using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task01
{

    public sealed class TVLCD : ElectronicDevice
    {
        public string Resolution;

        public TVLCD(string name, int power, string resolution) : base(name, power)
        {
            this.Resolution = resolution;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, resolution:{Resolution}";
        }

    }

    public class TVCRT : ElectronicDevice
    {
        public int Frequency;

        public TVCRT(string name, int power, int frequency) : base(name, power)
        {
            this.Frequency = frequency;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, frequency:{this.Frequency}";
        }

    }

}
