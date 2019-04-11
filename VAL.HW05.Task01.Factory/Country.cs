using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW05.Task01.Factory
{
    class Country
    {
        public string Name { get; private set; }

        public Country(string name)
        {
            this.Name = name;
        }

        public List<Order> GenerateNewOrders(int ordersCount)
        {
            if (ordersCount <= 0)
            {
                Console.WriteLine($"Can't generate new orders, invalid orders number: {ordersCount}");
                return null;
            }

            Random deviceRandomizer = new Random();
            List<Order> orders = new List<Order>();
            for (int i = 0; i < ordersCount; i++)
            {
                Order newOrder = GenerateNewOrder(deviceRandomizer);
                orders.Add(newOrder);
            }
            return orders;
        }

        internal List<Worker> HireWorkers(int workersCount)
        {
            List<Worker> newWorkers = new List<Worker>();
            Random skillsRandomizer = new Random();
            for (int i = 0; i < workersCount; i++)
            {
                int workCapacity = Variables.WorkCapacityList[skillsRandomizer.Next(0, 3)];
                newWorkers.Add(new Worker(workCapacity));
            }
            return newWorkers;
        }

        private Order GenerateNewOrder(Random deviceRandomizer)
        {
            Order newOrder = new Order();
            newOrder.Tanks = new List<Tank>();
            newOrder.Cars = new List<Car>();
            Random partRandomizer = new Random();

            int a = deviceRandomizer.Next(1, Variables.NewOrdersQty);
            for (int j = 0; j < a; j++)
            {
                newOrder.Tanks.Add(new Tank(partRandomizer.Next(1, Variables.NewPartsMaxQty)));
            }

            int b = deviceRandomizer.Next(1, Variables.NewOrdersQty);
            for (int j = 0; j < b; j++)
            {
                newOrder.Cars.Add(new Car(partRandomizer.Next(1, Variables.NewPartsMaxQty)));
            }
            return newOrder;
        }
         
    }
}
