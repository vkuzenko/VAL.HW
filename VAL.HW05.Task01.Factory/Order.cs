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
        public bool IsCompleted { get; private set; } 

        public Order()
        {
            this.OrderNumber = Guid.NewGuid();
            this.OrderNumberShort = this.OrderNumber.ToString().Substring(0, 4).ToUpper();
        }

        internal void CheckAndClose()
        {
            foreach (var car in this.Cars)
            {
                if (!car.IsCompleted)
                {
                    return;
                }
            }

            foreach (var tank in this.Tanks)
            {
                if (!tank.IsCompleted)
                {
                    return;
                }
            }

            this.IsCompleted = true;
        }

    }
}