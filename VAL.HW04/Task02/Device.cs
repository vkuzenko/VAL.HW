using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Device
    {
        public string Name;
        public int PartsQty;
        public int CurrPartPosition;
        public bool IsCompleted;
        public Part[] Parts;

        public Device(string name, int partsqty)
        {
            this.Name = name;
            this.PartsQty = partsqty;
            this.CurrPartPosition = 0;
            this.IsCompleted = false;
            this.Parts = new Part[partsqty];
        }

        public void AddPart(string WorkerName)
        {
            if (!IsCompleted && this.Parts[CurrPartPosition] == null)
            {
                this.Parts[CurrPartPosition] = new Part("P" + CurrPartPosition.ToString(), WorkerName);
                if (CurrPartPosition < this.Parts.Length - 1)
                {
                    this.CurrPartPosition = CurrPartPosition + 1;
                }
                else
                {
                    IsCompleted = true;
                }              
            }
        }

        public string GetPartsList()
        {
            string PartsList;
            PartsList = $"Device:{this.Name}, Parts:{this.PartsQty}\r\n";
            foreach (var Part in this.Parts)
            {
                if (Part != null)
                {
                    PartsList = PartsList + $"Part:{Part.Name}, By:{Part.WorkerName}\r\n";
                }
                else
                {
                    PartsList = PartsList + "Part:-\r\n";
                }
            }
            PartsList = PartsList + "\r\n";
            return PartsList;
        }

    }
}
