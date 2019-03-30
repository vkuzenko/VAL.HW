using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW04.Task01
{
    public class ComputerNotebook
    {
        private string Name;
        private int Power;
        private int RAM;
        private int Weight;

        public ComputerNotebook(string name, int power, int ram, int weight)
        {
            this.Name = name;
            this.Power = power;
            this.RAM = ram;
            this.Weight = weight;
        }

        public string GetDescription()
        {
            return $"ComputerNotebook name:{this.Name}m power:{this.Power}, RAM:{this.RAM}, weight:{this.Weight}";
        }
    }

    public class ComputerServer
    {
        private string Name;
        private int Power;
        private int RAM;
        private int Processors;

        public ComputerServer(string name, int power, int ram, int processors)
        {
            this.Name = name;
            this.Power = power;
            this.RAM = ram;
            this.Processors = processors;
        }

        public string GetDescription()
        {
            return $"ComputerServer name:{this.Name}m power:{this.Power}, RAM:{this.RAM}, processors:{this.Processors}";
        }
    }


}
