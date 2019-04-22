using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace VAL.HW07.Task01.Logger
{
    class StorageFile : IStorage
    {
        private string FileName { get; }

        public void Write(string message)
        {
            File.AppendAllText(this.FileName, message + "\r\n");
        }
        public StorageFile(string fileName)
        {
            FileName = fileName;
        }
    }
}
