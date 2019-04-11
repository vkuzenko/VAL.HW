using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW05.Task01.Factory
{
    class Craft
    {
        public string Name { get; private set; }
        public Country Country { get; private set; }
        public List<Worker> Workers { get; private set; }
        public List<Order> Orders { get; private set; }
        private Order OpenOrder;

        public Craft(string name, Country country)
        {
            this.Name = name;
            this.Country = country;
            this.Workers = country.HireWorkers(Variables.NewWorkersQty);
            this.Orders = country.GenerateNewOrders(Variables.NewOrdersQty);
        }

        internal void StartYear()
        {
            for (int i = 0; i < 12; i++)
            {
                Logger.LogInfo($"Month:{i.ToString("00")}");
                this.StartMonth();
            }
        }

        private void StartMonth()
        {
            for (int i = 0; i < 30; i++)
            {
                Logger.LogInfo($"Day:{i.ToString("00")}");
                this.StartDay();
                Console.ReadLine();
            }
        }

        private void StartDay()
        {
            foreach (var worker in this.Workers)
            {

                OpenOrder = this.GetOpenOrder();
                if (OpenOrder == null)
                {
                    Logger.LogWarning("Orders are over!");
                    this.Orders.AddRange(Country.GenerateNewOrders(Variables.NewOrdersQty));
                    OpenOrder = this.GetOpenOrder();
                }

                Tank notCompletedTank = this.GetOpenTank(OpenOrder);
                if (notCompletedTank == null)
                {
                    Car notCompletedCar = this.GetOpenCar(OpenOrder);
                    if (notCompletedCar != null)
                    {
                        worker.AddPartsToAgregate(notCompletedCar);
                        Logger.LogInfo($"Order:{OpenOrder.OrderNumberShort} Car:{notCompletedCar.IdShort}({notCompletedCar.PartsQty.ToString("00")}/{notCompletedCar.PartsAdded.ToString("00")}) Worker:{worker.IdShort} Parts:{worker.WorkCapacity.ToString("00")}");
                    }
                }
                else
                {
                    worker.AddPartsToAgregate(notCompletedTank);
                    Logger.LogInfo($"Order:{OpenOrder.OrderNumberShort} Tnk:{notCompletedTank.IdShort}({notCompletedTank.PartsQty.ToString("00")}/{notCompletedTank.PartsAdded.ToString("00")}) Worker:{worker.IdShort} Parts:{worker.WorkCapacity.ToString("00")}");
                }
                OpenOrder.CheckAndClose();
            }

        }

        private Car GetOpenCar(Order order)
        {
            foreach (var car in order.Cars)
            {
                if (!car.IsCompleted)
                {
                    return car;
                }
            }
            return null;
        }

        private Tank GetOpenTank(Order order)
        {
            foreach (var tank in order.Tanks)
            {
                if (!tank.IsCompleted)
                {
                    return tank;
                }
            }
            return null;
        }

        private Order GetOpenOrder()
        {
            foreach (var order in this.Orders)
            {
                if (!order.IsCompleted)
                {
                    return order;
                }
            }
            return null;
        }
    }
}
