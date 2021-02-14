using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Nerizza Flores 03/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("\t C# Console Applications 2020");
            Console.WriteLine("\t\t by Nerizza Flores");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine(" 1. Distance Converter");
            Console.WriteLine(" 2. BMI Calculator");
            Console.WriteLine();

            Console.WriteLine(" Select your application > ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    DistanceConverter converter = new DistanceConverter();
                    converter.ConvertDistance();
                    Console.WriteLine("You have chosen Distance Converter!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }    
        }
    }
}
