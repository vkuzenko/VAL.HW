using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task01
{
    public abstract class ElectronicDevice
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Power { get; private set; }

        public ElectronicDevice(string name, int power)
        {
            this.Id = Numerator.GetInstance().GetId();
            this.Name = name;
            this.Power = power;
        }

        public override string ToString()
        {
            return $"{Id}, {this.GetType()} name:{Name}, power:{Power}";
        }
    }
}
