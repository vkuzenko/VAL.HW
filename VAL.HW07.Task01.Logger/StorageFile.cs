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
        private string FileName;
        static Timer LogTimer;
        private string Message;

        public void Write(string message)
        {
            Message = Message + message + "\r\n";
        }
        public StorageFile(string fileName, int saveToFileInterval)
        {
            FileName = fileName;
            LogTimer = new Timer(new TimerCallback(WriteToFile), null, 0, saveToFileInterval);
        }

        private void WriteToFile(object state)
        {
            string message;
            if (string.IsNullOrEmpty(Message))
            {
                return;
            }
            message = Message;
            Message = "";
            File.AppendAllText(this.FileName, message);
        }
    }
}
