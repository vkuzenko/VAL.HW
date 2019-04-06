using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW05.Task01.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Country newCountry = new Country(Variables.CountryName);
            Craft newCraft = new Craft(Variables.CraftName, newCountry);
            newCraft.StartYear();
        }
    }
}
