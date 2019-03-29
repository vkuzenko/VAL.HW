using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Worker
    {
        public string Name { get; }
        public int WorkCapacity { get; }

        public Worker(string name, int partsLevel)
        {
            this.Name = name;
            this.WorkCapacity = partsLevel;
        }

        public void AddPartsToDevice(Device device)
        {
            for (int i = 0; i < this.WorkCapacity; i++)
            {
                device.AddPart(this.Name);
            }   
        }
    }
}
