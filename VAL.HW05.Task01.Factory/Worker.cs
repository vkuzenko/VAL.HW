using System;

namespace VAL.HW05.Task01.Factory
{
    public class Worker
    {
        public Guid Id { get; private set; }
        public string IdShort { get; }
        public int WorkCapacity { get; private set; }
        public int Salary { get; private set; }

        public Worker(int workCapacity)
        {
            this.Id = Guid.NewGuid();
            this.IdShort = this.Id.ToString().Substring(0, 4).ToUpper();
            this.WorkCapacity = workCapacity;
            this.Salary = this.WorkCapacity * Variables.PartSalaryRate * 30;
        }

        internal void AddPartsToAgregate(Tank tank)
        {
            for (int i = 0; i < this.WorkCapacity; i++)
            {
                tank.PartsAdded++;
                if (tank.PartsAdded == tank.PartsQty)
                {
                    tank.IsCompleted = true;
                    return;
                }
            }
        }

        internal void AddPartsToAgregate(Car car)
        {
            for (int i = 0; i < this.WorkCapacity; i++)
            {
                car.PartsAdded++;
                if (car.PartsAdded == car.PartsQty)
                {
                    car.IsCompleted = true;
                    return;
                }                                 
            }
        }
    }
}