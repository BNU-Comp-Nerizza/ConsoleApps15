﻿using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Rhis App will prompt the user to input a distance
    /// measured in one unit and it will calculate and 
    /// output the equicalent distance in another unit.
    /// </summary>
    /// <author>
    /// Nerizza Flores version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// Call other methods
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit("Please select the from distance unit >");
            toUnit = SelectUnit("Please select the to distance unit > ");

            Console.WriteLine($"Converting {fromUnit} to {toUnit}\n");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");
            CalculateDistance();
            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            } 
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\nYou have chosen {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {            
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            return null;
        }

        private static string DisplayChoice(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
            
        }

        private void OutputDistance()
        {
            Console.WriteLine($"\n{fromDistance}  {fromUnit} is {toDistance} {toUnit}.\n");
        }

        /// <summary>
        /// Print out the heading
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\tDistance Converter     ");
            Console.WriteLine("\tby Nerizza Flores       ");
            Console.WriteLine("------------------------------\n");
        }
    }
}
