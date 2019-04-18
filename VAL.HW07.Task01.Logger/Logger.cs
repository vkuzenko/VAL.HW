using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    class Logger : ILogger
    {
        public List<IStorage> LogStorages { get; } = new List<IStorage>();

        private LogLevels _LogLevel;
        public LogLevels LogLevel
        {
            get
            {
                return _LogLevel;
            }
            set
            {
                _LogLevel = value;
            }
        }

        public void WriteLogToStorage(LogLevels level, string type, string message)
        {
            if (level >= this.LogLevel)
            {
                foreach (IStorage logStorage in LogStorages)
                {
                    logStorage.Write($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, [{type}], {message}");
                }
            }
        }

        public void Debug(string message)
        {
            this.WriteLogToStorage(LogLevels.Debug, "Debug", message);
        }

        public void Info(string message)
        {
            this.WriteLogToStorage(LogLevels.Info, "Info", message);
        }

        public void Warn(string message)
        {
            this.WriteLogToStorage(LogLevels.Warn, "Warn", message);
        }

        public void Error(string message)
        {
            this.WriteLogToStorage(LogLevels.Error, "Error", message);
        }

        public void Fatal(string message)
        {
            this.WriteLogToStorage(LogLevels.Fatal, "Fatal", message);
        }


    }
}
