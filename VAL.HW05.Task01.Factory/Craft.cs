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
            Order openOrder;

            //foreach (var worker in this.Workers)
            //{
            //    do
            //    {
            //        openOrder = this.GetOpenOrder();
            //        Tank notCompletedTank = this.GetOpenTank(openOrder);
            //        if (notCompletedTank == null)
            //        {
            //            Car notCompletedCar = this.GetOpenCar(openOrder);
            //            if (notCompletedCar != null)
            //            {
            //                worker.AddPartsToAgregate(notCompletedCar);
            //            }
            //        }
            //        else
            //        {
            //            worker.AddPartsToAgregate(notCompletedTank);
            //        }
            //        CheckAndCloseOrder(openOrder);
            //    } while (openOrder != null);

            //    Country.GenerateNewOrders(Variables.NewOrdersQty);
            //}

            foreach (var worker in this.Workers)
            {

                openOrder = this.GetOpenOrder();
                if (openOrder == null)
                {
                    Logger.LogWarning("Orders are over!");
                    this.Orders.AddRange(Country.GenerateNewOrders(Variables.NewOrdersQty));
                    openOrder = this.GetOpenOrder();
                }

                Tank notCompletedTank = this.GetOpenTank(openOrder);
                if (notCompletedTank == null)
                {
                    Car notCompletedCar = this.GetOpenCar(openOrder);
                    if (notCompletedCar != null)
                    {
                        worker.AddPartsToAgregate(notCompletedCar);
                        Logger.LogInfo($"Order:{openOrder.OrderNumberShort} Car:{notCompletedCar.IdShort}({notCompletedCar.PartsQty.ToString("00")}/{notCompletedCar.PartsAdded.ToString("00")}) Worker:{worker.IdShort} Parts:{worker.WorkCapacity.ToString("00")}");
                    }
                }
                else
                {
                    worker.AddPartsToAgregate(notCompletedTank);
                    Logger.LogInfo($"Order:{openOrder.OrderNumberShort} Tnk:{notCompletedTank.IdShort}({notCompletedTank.PartsQty.ToString("00")}/{notCompletedTank.PartsAdded.ToString("00")}) Worker:{worker.IdShort} Parts:{worker.WorkCapacity.ToString("00")}");
                }
                CheckAndCloseOrder(openOrder);
            }

        }

    internal void CheckAndCloseOrder(Order order)
        {
            foreach (var car in order.Cars)
            {
                if (!car.IsCompleted)
                {
                    return;
                }
            }

            foreach (var tank in order.Tanks)
            {
                if (!tank.IsCompleted)
                {
                    return;
                }
            }

            order.IsCompleted = true;
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
