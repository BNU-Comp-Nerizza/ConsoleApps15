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
        private double fromDistance;
        private double toDistance;
        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        /// <summary>
        /// Constructor of the DistanceConverter Class
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// Call other methods 
        /// Prompts the user to input which unit the distance which will be converted from
        /// and which unit it will be converted to. 
        /// </summary>
        public void ConvertDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");

            fromUnit = SelectUnit ("Please select the from distance unit > ");
            toUnit = SelectUnit ("Please select the to distance unit > ");

            Console.WriteLine($"Converting {fromUnit} to {toUnit}\n");

            fromDistance = ConsoleHelper.InputNumber($"Please enter the number of {fromUnit} > ");
            CalculateDistance();
            OutputDistance();
        }

        /// <summary>
        /// Calculate the distance based on the user choice
        /// Used enum for the units
        /// </summary>
        public void CalculateDistance()
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

        /// <summary>
        /// Prompt the user to select their chosen (choices)unit
        /// </summary>
        /// <param name="prompt"> the user choice</param>
        /// <returns>the unit of the user choice</returns>
        private DistanceUnits SelectUnit(string prompt)
        {
            string[] choices =
            {
                DistanceUnits.Feet.ToString(),
                DistanceUnits.Metres.ToString(),
                DistanceUnits.Miles.ToString()
            };
            Console.WriteLine(prompt);
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            return ExecuteUnit(choiceNo);
        }

        /// <summary>
        /// Execute the choice based on the user input
        /// </summary>
        /// <param name="choice"> the user choice(input)</param>
        /// <returns>The unit based on the user choice </returns>
        private static DistanceUnits ExecuteUnit(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    return DistanceUnits.Feet;
                case 2:
                    return DistanceUnits.Metres;
                case 3:
                    return DistanceUnits.Miles;
                default:
                    Console.WriteLine("\nInvalid Choice.\nYou must select a digit between 1 and 3.\n");
                    return DistanceUnits.NoUnit;
            }
        }

        /// <summary>
        /// Display the result of the calculation
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n{fromDistance} {fromUnit} is {toDistance} {toUnit}.\n");
        }
    }
}
