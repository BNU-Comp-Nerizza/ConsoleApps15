﻿using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given 
    /// distance measured in miles to the equicalent 
    /// distance measured in feet
    /// </summary>
    /// <author>
    /// Nerizza Flores version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        public const int FEET_IN_MILES = 5280;

        /// <summary>
        /// Call other methods
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Calculate the feet
        /// Convert miles to feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Print out the calculation
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
    }
}
