using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task01
{
    public class Player : ElectronicDevice
    {
        public string[] Formats;

        public Player(string name, int power, string[] formats) : base(name, power)
        {
            this.Formats = formats;
        }

        private string GetFormats()
        {
            string allFormats = "";
            for (int i = 0; i < this.Formats.Length; i++)
            {
                allFormats = allFormats + this.Formats[i] + " ";
            }
            return allFormats;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, formats:{this.GetFormats()}";
        }

    }
}
