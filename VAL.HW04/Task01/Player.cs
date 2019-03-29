using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public class Player
    {
        private string Name;
        private int Power;
        private string[] Formats;

        public Player(string name, int power, string[] formats)
        {
            this.Name = name;
            this.Power = power;
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

        public string GetDescription()
        {
            return $"Player name:{this.Name}, power:{this.Power}, formats:{this.GetFormats()}";
        }

    }
}
