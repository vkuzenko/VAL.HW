using System;
using System.Collections.Generic;

namespace VAL.HW05.Task01.Factory
{
    public class Tank
    {
        public Guid Id { get; private set; }
        public string IdShort { get; }
        public int PartsQty { get; private set; }
        public int PartsAdded { get; set; }
        public bool IsCompleted { get; set; }

        public Tank(int partsQty)
        {
            this.Id = Guid.NewGuid();
            this.IdShort = this.Id.ToString().Substring(0, 4).ToUpper();
            this.PartsQty = partsQty;
        }
    }
}