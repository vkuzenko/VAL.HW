using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW06.Task01
{
    public class Numerator
    {
        private static Numerator instance;

        private int Id;

        protected Numerator()
        {
            Random random = new Random();
            this.Id = random.Next(0,100);
        }

        public static Numerator GetInstance()
        {
            if (instance == null)
            {
                instance = new Numerator();
            }
            return instance;
        }

        public int GetId()
        {
            Id++;
            return Id;
        }

    }
}
