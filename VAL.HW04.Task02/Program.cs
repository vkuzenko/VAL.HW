using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW04.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> Workers = new List<Worker>();
            List<Device> Devices = new List<Device>();

            Workers.Add(new Worker("Ivan", 1));
            Workers.Add(new Worker("Petr", 3));
            Workers.Add(new Worker("Fedor", 5));

            Devices.Add(new Device("Device01", 10));
            Devices.Add(new Device("Device02", 5));

            foreach (var Device in Devices)
            {
                while (!Device.IsCompleted)
                {
                    foreach (var Worker in Workers)
                    {
                        if (!Device.IsCompleted)
                        {
                            Worker.AddPartsToDevice(Device);
                        }
                    }
                }
                Console.WriteLine(Device.GetPartsList());
            }

            Console.ReadLine();
        }
    }
}
