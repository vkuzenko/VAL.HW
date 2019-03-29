using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class TVLCD
    {
        private string Name;
        private int Power;
        private string Resolution;

        public TVLCD(string name, int power, string resolution)
        {
            this.Name = name;
            this.Power = power;
            this.Resolution = resolution;
        }

        public string GetDescription()
        {
            return $"TVLCD name:{this.Name}, power:{this.Power}, resolution:{this.Resolution}";
        }

    }

    public class TVCRT
    {
        private string Name;
        private int Power;
        private int Frequency;

        public TVCRT(string name, int power, int frequency)
        {
            this.Name = name;
            this.Power = power;
            this.Frequency = frequency;
        }

        public string GetDescription()
        {
            return $"TVCRT name:{this.Name}, power:{this.Power}, frequency:{this.Frequency}";
        }

    }
}
