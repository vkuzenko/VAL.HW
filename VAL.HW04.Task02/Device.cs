using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW04.Task02
{
    class Device
    {

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
        }

        private int _PartsQty;
        public int PartsQty
        {
            get
            {
                return _PartsQty;
            }
        }

        private bool _IsCompleted;
        public bool IsCompleted
        {
            get
            {
                return _IsCompleted;
            }
        }
        
        private Part[] Parts;
        private int CurrPartPosition = 0;

        public Device(string name, int partsQty)
        {
            this._Name = name;
            this._PartsQty = partsQty;
            this._IsCompleted = false;
            this.Parts = new Part[partsQty];
        }

        public void AddPart(string workerName)
        {
            if (!IsCompleted && this.Parts[CurrPartPosition] == null)
            {
                this.Parts[CurrPartPosition] = new Part("P" + CurrPartPosition.ToString(), workerName);
                if (CurrPartPosition < this.Parts.Length - 1)
                {
                    this.CurrPartPosition = CurrPartPosition + 1;
                }
                else
                {
                    this._IsCompleted = true;
                }              
            }
        }

        public string GetPartsList()
        {
            string PartsList;
            PartsList = $"Device:{this._Name}, Parts:{this._PartsQty}\r\n";
            foreach (var Part in this.Parts)
            {
                if (Part != null)
                {
                    PartsList = PartsList + $"Part:{Part.Name}, By:{Part.AddedByWorker}\r\n";
                }
                else
                {
                    PartsList = PartsList + "Part:-\r\n";
                }
            }
            return PartsList;
        }

    }
}
