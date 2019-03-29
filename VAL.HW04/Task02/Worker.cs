using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Worker
    {
        public string Name;
        public int PartsLevel;

        public Worker(string name, int partslevel)
        {
            this.Name = name;
            this.PartsLevel = partslevel;
        }

        public void AddParts(Device Device)
        {
            for (int i = 0; i < this.PartsLevel; i++)
            {
                Device.AddPart(this.Name);
            }   
        }
    }
}
