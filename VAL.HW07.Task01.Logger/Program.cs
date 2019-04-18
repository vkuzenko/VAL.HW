using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    public enum LogLevels
    {
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5
    }

    class Program
    {
        static void Main(string[] args)
        {
                Logger logger = new Logger();
                logger.LogLevel = LogLevels.Info;
                //logger.LogStorages.Add(new StorageConsole());
                logger.LogStorages.Add(new StorageFile("logger.log", 1000));

                logger.Info("Application started");

            try
            {
                string s;
                int x;
                int y;
                bool stopEntry = false;
                List<Point> points = new List<Point>();

                do
                {
                    Console.Write("Enter X: ");
                    s = Console.ReadLine();
                    logger.Debug($"Enter X: {s}");
                    x = Convert.ToInt16(s);

                    Console.Write("Enter Y: ");
                    s = Console.ReadLine();
                    logger.Debug($"Enter Y: {s}");
                    y = Convert.ToInt16(s);

                    points.Add(new Point(x, y));

                    Console.Write("Add another point? (Y/N): ");
                    s = Console.ReadLine();
                    logger.Debug($"Add another point? (Y/N): {s}");
                    if (s.ToUpper() == "N")
                    {
                        stopEntry = true;
                    }

                    Console.WriteLine();
                    logger.Info($"Point: {x}, {y}");

                } while (!stopEntry);

                LandArea landArea = new LandArea(points);
                Console.WriteLine($"Your land area size is: {landArea.GetLandArea()}m2");
                logger.Info($"Your land area size is: {landArea.GetLandArea()}m2");

                Console.Write("\r\nPress any key to close...");
                Console.ReadLine();

            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
                Console.WriteLine($"Oops, we've got an error: {ex.Message}! \n\rPress any key to close...");
                Console.Read();
            }

        }
    }
}
