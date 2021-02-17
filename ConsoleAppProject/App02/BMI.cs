using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        private double Weight;
        private double Height;

        private double Stone;
        private double Pound;
        private double Feet;
        private double Inch;

        public const int POUNDS_IN_STONES = 14;
        public const int INCH_IN_FEET = 12;

        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double ObeseClassI = 34.9;
        public const double ObeseClassII = 39.9;
        public const double ObeseClassIII = 40.0;

        public double BMIResult;

        private BMIUnit unit;

        public void ConvertBMI()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");
            unit = SelectUnit("Please enter your choice ");
            OutputBMIClass();
            OutputBAME();
        }

        private BMIUnit SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            unit = ExecuteChoice(choice);
            return unit;
        }

        private BMIUnit ExecuteChoice(string choice)
        {
            Console.WriteLine($"\nYou have chosen {unit}");
            switch (choice)
            {
                case "1":
                    unit = BMIUnit.Metric;

                    CalculateMetric();
                    break;
                case "2":
                    unit = BMIUnit.Imperial;
                    CalculateImperial();
                    break;
                default:
                    unit = BMIUnit.NoUnit;
                    break;
            }

            if (unit == BMIUnit.NoUnit)
            {
                Console.WriteLine("\nInvalid Choice.\nYou must select a digit between 1 and 2.\n");
            }
            return unit;
        }

        private static string DisplayChoice(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {BMIUnit.Metric}");
            Console.WriteLine($" 2. {BMIUnit.Imperial}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void OutputBAME()
        {
            Console.WriteLine();
            Console.WriteLine("\n\tIf you are Black, Asian or other minority");
            Console.WriteLine("\tethnic groups, you have a higher risk!");
            Console.WriteLine("\n\tAdults 23.0 or more are at increased risk;");
            Console.WriteLine("\tAdults 27.5 or more are at high risk.");
            Console.WriteLine();
        }

        private void OutputBMIClass()
        {
            if (BMIResult < Underweight)
            {
                Console.WriteLine($"Your BMI is {BMIResult}. You are classified as Underweight");
            }
            else if (BMIResult >= Underweight && BMIResult <= Normal)
            {
                Console.WriteLine($"Your BMI is {BMIResult}. You are classified as Normal");
            }
            else if (BMIResult >= Normal && BMIResult <= Overweight)
            {
                Console.WriteLine($"Your BMI is {BMIResult}. You are classified as Overweight");
            }
            else if (BMIResult >= Overweight && BMIResult <= ObeseClassI)
            {
                Console.WriteLine($"Your BMI is {BMIResult}. You are classified as Obese Class I");
            }
            else if (BMIResult >= ObeseClassI && BMIResult <= ObeseClassII)
            {
                Console.WriteLine($"Your BMI is {BMIResult}. You are classified as Obese Class II");
            }
            else if (BMIResult >= ObeseClassIII)
            {
                Console.WriteLine($"Your BMI is {BMIResult}. You are classified as Obese Class III");
            }
        }

        private void CalculateImperial()
        {
            Console.WriteLine("\nEnter your Height:");
            Feet = ConsoleHelper.InputNumber("--in Feet > ");
            Inch = ConsoleHelper.InputNumber("--in Inches > ");
            Console.WriteLine("\nEnter your Weight:");
            Stone = ConsoleHelper.InputNumber("--in Stones > ");
            Pound = ConsoleHelper.InputNumber("--in Pounds > ");
            Weight = (Pound += Stone * POUNDS_IN_STONES);
            Height = (Inch += Feet * INCH_IN_FEET);
            BMIResult = (Weight * 703) / (Height * Height); 
        }

        private void CalculateMetric()
        {
            Weight = ConsoleHelper.InputNumber("\nEnter your weight to the nearest Kg > ");
            Height = ConsoleHelper.InputNumber("\nEnter your height to the nearest meters > ");
            BMIResult = Weight / (Height * Height);
        }
    }
}
