using System;
using System.IO;

namespace VAL.HW05.Task01.Factory
{
    public class Logger
    {
        public static int messageNo;

        public static void LogInfo(string message)
        {
            messageNo++;
            message = $"{messageNo.ToString("0000")} Info {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} {message}";
            Console.WriteLine(message);
            File.AppendAllText("log.txt", message + "\r\n");

        }

        public static void LogWarning(string message)
        {
            messageNo++;
            message = $"{messageNo.ToString("0000")} Warning {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} {message}";
            Console.WriteLine(message);
            File.AppendAllText("log.txt", message + "\r\n");
        }
    }
}
