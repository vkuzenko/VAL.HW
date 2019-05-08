using System;
using System.Collections.Generic;

namespace VAL.HW07.Task01.Logger
{
    class Logger : ILogger
    {

        public enum LogLevels
        {
            Debug = 1,
            Info = 2,
            Warn = 3,
            Error = 4,
            Fatal = 5
        }

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

        public void WriteLogToStorage(LogLevels level, string message)
        {
            if (level >= this.LogLevel)
            {
                foreach (IStorage logStorage in LogStorages)
                {
                    logStorage.Write($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, [{Enum.GetName(typeof(LogLevels), level)}], {message}");
                }
            }
        }

        public void Debug(string message)
        {
            this.WriteLogToStorage(LogLevels.Debug, message);
        }

        public void Info(string message)
        {
            this.WriteLogToStorage(LogLevels.Info, message);
        }

        public void Warn(string message)
        {
            this.WriteLogToStorage(LogLevels.Warn, message);
        }

        public void Error(string message)
        {
            this.WriteLogToStorage(LogLevels.Error, message);
        }

        public void Fatal(string message)
        {
            this.WriteLogToStorage(LogLevels.Fatal, message);
        }


    }
}
