using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStatusConsoleApp
{
    internal class Program
    {
        public static string filepath = @"C:\Users\parvathy\Desktop\CarRunningStatus.txt";
        static void Main(string[] args)
        {
            string carStatus = "stopped";
            while(true)
            {
                Console.Write("Enter command:");
                string command=Console.ReadLine();
                if(command == "start")
                {
                    if (carStatus == "started")
                    {
                        Console.WriteLine("Car is already started");
                        Console.ReadKey();  
                    }
                    else
                    {
                        Console.WriteLine("Car Started");
                        Console.ReadKey();
                        carStatus = "started";
                    }
                }
                else if(command=="stop")
                {
                    if (carStatus == "stopped")
                    {
                        Console.WriteLine("Car is already stopped");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Car stopped");
                        Console.ReadKey();
                        carStatus = "stopped";
                    }
                }
                else{
                    Console.WriteLine("Invalid command");
                    Console.ReadKey();
                }
                    Console.Clear();
            }
        }
    }
}
