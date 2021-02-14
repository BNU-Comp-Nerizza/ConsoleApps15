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
    /// modified by 14/02/2021
    /// </author>
    public class DistanceConverter
    {
        // constants for distance coversion
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        //initialised instance variables
        public double FromDistance { get; set; }
        public double ToDistance { get; set;  }
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }
        private DistanceUnits unit;

        /// <summary>
        /// Constructor of the DistanceConverter Class
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// Call other methods 
        /// Prompts the user to input which unit the distance which will be converted from
        /// and which unit it will be converted to. 
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit ("Please select the from distance unit > ");
            ToUnit = SelectUnit ("Please select the to distance unit > ");

            Console.WriteLine($"Converting {FromUnit} to {ToUnit}\n");

            FromDistance = InputDistance($"Please enter the number of {FromUnit} > ");
            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// Calculate the distance based on the user choice
        /// Used enum for the units
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            } 
        }

        /// <summary>
        /// Prompt the user to select their chosen (choices)unit
        /// </summary>
        /// <param name="prompt"> the user choice</param>
        /// <returns>the unit of the user choice</returns>
        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            unit = ExecuteChoice(choice);
            Console.WriteLine($"\nYou have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// Execute the choice based on the user input
        /// </summary>
        /// <param name="choice"> the user choice(input)</param>
        /// <returns>The unit based on the user choice </returns>
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

        /// <summary>
        /// Display the menu of the distance unit then prompts users
        /// to select one and return it
        /// </summary>
        /// <param name="prompt"> the user choice </param>
        /// <returns>returns the user choice </returns>
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

        /// <summary>
        /// Prompt the user to enter the distance value
        /// </summary>
        /// <param name="prompt">the user input of the distance value</param>
        /// <returns> string value will be converted and return as a double value </returns>
        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Display the result of the calculation
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n{FromDistance} {FromUnit} is {ToDistance} {ToUnit}.\n");
        }
    }
}
