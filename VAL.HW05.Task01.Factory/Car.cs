using System;
using System.Collections.Generic;

namespace VAL.HW05.Task01.Factory
{
    public class Car
    {
        public string Id { get; private set; }
        public string IdShort { get; }
        public int PartsQty { get; private set; }
        public int PartsAdded { get; set; }
        public bool IsCompleted { get; set; }

        public Car(int partsQty)
        {
            this.Id = Guid.NewGuid().ToString().PadRight(4).ToUpper();
            this.IdShort = this.Id.ToString().Substring(0, 4).ToUpper();
            this.PartsQty = partsQty;
        }
    }
}