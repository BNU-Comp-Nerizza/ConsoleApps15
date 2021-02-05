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
        public const double METRES_IN_MILES = 1609.34;
        private double miles;
        private double feet;
        private double metres;
        
        /// <summary>
        /// Call other methods
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");
            miles = InputDistance("Please enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, "miles", feet, "feet");
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, "feet", miles, "miles");
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting to Miles to Metres");
            miles = InputDistance("Please enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, "miles", metres, "metres");
        }

        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES ;
        
        }

        /// <summary>
        /// Calculate the feet
        /// Convert miles to feet
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }


        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(double fromDistance, string fromUnit, double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit} is {toDistance} {toUnit}.");
        }



        /// <summary>
        /// Print out the heading
        /// </summary>
        private void OutputHeading(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\tDistance Converter     ");
            Console.WriteLine("\tby Nerizza Flores       ");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }



    }
}
