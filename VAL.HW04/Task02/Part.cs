using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Part
    {
        public string Name { get; }
        public string AddedByWorker { get; }

        public Part(string name, string workerName)
        {
            this.Name = name;
            this.AddedByWorker = workerName;
        }
    }

}
