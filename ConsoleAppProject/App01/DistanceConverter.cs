using System;

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
        public const int FEET_IN_MILES = 5280;
        private double miles;
        private double feet;
        
        /// <summary>
        /// Call other methods
        /// </summary>
        public void Run()
        {
            OutputHeading();
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

        /// <summary>
        /// Print out the heading
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("     Conver Miles to Feet     ");
            Console.WriteLine("      by Nerizza Flores       ");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine();
        }
    }
}
