using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
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

        private double fromDistance;
        private double toDistance;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        private DistanceUnits unit;

        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// Call other methods
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit ("Please select the from distance unit > ");
            toUnit = SelectUnit ("Please select the to distance unit > ");

            Console.WriteLine($"Converting {fromUnit} to {toUnit}\n");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");
            CalculateDistance();
            OutputDistance();
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

        /// <summary>
        /// Calculate the distance using enum for the units
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            } 
        }

        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            unit = ExecuteChoice(choice);
            Console.WriteLine($"\nYou have chosen {unit}");
            return unit;
        }

        private DistanceUnits ExecuteChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    unit = DistanceUnits.Feet;
                    break;
                case "2":
                    unit = DistanceUnits.Metres;
                    break;
                case "3":
                    unit = DistanceUnits.Miles;
                    break;
                default:
                    unit = DistanceUnits.NoUnit;
                    break;
            }

            if (unit == DistanceUnits.NoUnit)
            {
                Console.WriteLine("\nInvalid Choice.\nYou must select a digit between 1 and 3.\n");
            }
            return unit;
        }

        private static string DisplayChoice(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {DistanceUnits.Feet}");
            Console.WriteLine($" 2. {DistanceUnits.Metres}");
            Console.WriteLine($" 3. {DistanceUnits.Miles}");
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
            Console.WriteLine($"\n{fromDistance} {fromUnit} is {toDistance} {toUnit}.\n");
        }
    }
}
