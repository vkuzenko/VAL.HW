using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Player
    {
        public string Name;
        public int Power;
        public string[] Formats;

        public Player(string name, int power, string[] formats)
        {
            this.Name = name;
            this.Power = power;
            this.Formats = formats;
        }

        public string GetDescription()
        {
            string AllFormats = "";
            for (int i = 0; i < this.Formats.Length; i++)
            {
                AllFormats = AllFormats + this.Formats[i] + " ";
            }
            return $"Player name:{this.Name}, power:{this.Power}, formats:{AllFormats}";
        }
    }
}
