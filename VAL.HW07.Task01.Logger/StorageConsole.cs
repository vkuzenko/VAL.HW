using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    class StorageConsole : IStorage
    {
        public void Write(string message)
        {
            Console.WriteLine($"{this.GetType().Name}: {message}");
        }
    }
}
