using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task01
{

    public abstract class Computer : ElectronicDevice
    {
        public int RAM;

        public Computer(string name, int power, int ram) : base(name, power)
        {
            this.RAM = ram;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, RAM:{this.RAM}";
        }
    }

    public class ComputerNotebook : Computer
    {
        public int Weight;

        public ComputerNotebook(string name, int power, int ram, int weight) : base(name, power, ram)
        {
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, weight:{this.Weight}";
        }
    }

    public class ComputerServer : Computer
    {
        public int Processors;

        public ComputerServer(string name, int power, int ram, int processors) : base(name, power, ram)
        {
            this.Processors = processors;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, processors:{this.Processors}";
        }
    }


}
