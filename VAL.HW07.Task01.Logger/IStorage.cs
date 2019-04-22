using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    public interface IStorage
    {
        void Write(string message);
    }
}
