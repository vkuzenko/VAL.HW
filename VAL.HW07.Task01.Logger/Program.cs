using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAL.HW07.Task01.Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogLevel = Logger.LogLevels.Info;
            //logger.LogStorages.Add(new StorageConsole());
            logger.LogStorages.Add(new StorageFile("logger.log"));
            logger.Info("Application started");
            LandArea landArea = new LandArea();

            string s;
            List<LandArea.Point> points = new List<LandArea.Point>();
            do
            {
                int x;
                int y;
                string msg;
                bool isNumberEntered;

                do
                {
                    isNumberEntered = false;
                    Console.Write("Enter X: ");
                    s = Console.ReadLine();
                    logger.Debug($"Enter X: {s}");
                    if (int.TryParse(s, out x))
                    {
                        isNumberEntered = true;
                    }
                    else
                    {
                        msg = $"X = {s} is not a number, please, try again!";
                        logger.Error(msg);
                        Console.WriteLine(msg);
                    }
                } while (!isNumberEntered);

                do
                {
                    isNumberEntered = false;
                    Console.Write("Enter Y: ");
                    s = Console.ReadLine();
                    logger.Debug($"Enter Y: {s}");
                    if (int.TryParse(s, out y))
                    {
                        isNumberEntered = true;
                    }
                    else
                    {
                        msg = $"Y = {s} is not a number, please, try again!";
                        logger.Error(msg);
                        Console.WriteLine(msg);
                    }
                } while (!isNumberEntered);

                landArea.Points.Add(new LandArea.Point(x, y));

                Console.Write("Add another point? (Y/N): ");
                s = Console.ReadLine();
                logger.Debug($"Add another point? (Y/N): {s}");

                Console.WriteLine();
                logger.Info($"Point: {x}, {y}");

            } while (s.ToUpper() != "N");

            Console.WriteLine($"Your land area size is: {landArea.GetLandArea()}m2");
            logger.Info($"Your land area size is: {landArea.GetLandArea()}m2");

            Console.Write("\r\nPress any key to close...");
            Console.ReadLine();
        }
    }
}
