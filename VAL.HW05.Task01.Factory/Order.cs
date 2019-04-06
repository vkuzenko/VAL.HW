using System;
using System.Collections.Generic;

namespace VAL.HW05.Task01.Factory
{
    public class Order
    {
        public Guid OrderNumber { get; private set; }
        public string OrderNumberShort { get; }
        public List<Tank> Tanks { get; set; }
        public List<Car> Cars { get; set; }
        public bool IsCompleted { get; set; } 

        public Order()
        {
            this.OrderNumber = Guid.NewGuid();
            this.OrderNumberShort = this.OrderNumber.ToString().Substring(0, 4).ToUpper();
        }
    }
}