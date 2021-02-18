using System;
using System.Text;

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
        public double BmiIndex { get; set; }

        public int Stone { get; set; }
        public int Pound { get; set; }
        public int Feet { get; set; }
        public int Inch { get; set; }
        public double Centimetres { get; set; }
        public double Kilograms { get; set; }
        public double Metres;

        public const int POUNDS_IN_STONES = 14;
        public const int INCH_IN_FEET = 12;

        public const double Underweight = 18.5;
        public const double Normal = 24.9;
        public const double Overweight = 29.9;
        public const double ObeseClassI = 34.9;
        public const double ObeseClassII = 39.9;
        public const double ObeseClassIII = 40.0;
               
        public BMIUnit unit { get; set; }

        public void ConvertBmi()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");
            unit = SelectUnit("Please enter your choice >");
            Console.WriteLine(OutputBmiCategory());
            Console.WriteLine(OutputBame());
        }

        private BMIUnit SelectUnit(string prompt)
        {
            string choice = DisplayChoice(prompt);
            unit = ExecuteChoice(choice);
            return unit;
        }

        private BMIUnit ExecuteChoice(string choice)
        {

            switch (choice)
            {
                case "1":
                    unit = BMIUnit.Metric;
                    Console.WriteLine($"\nYou have chosen {unit} unit.");
                    InputMetricValue();
                    CalculateMetric();
                    break;
                case "2":
                    unit = BMIUnit.Imperial;
                    Console.WriteLine($"\nYou have chosen {unit} unit.");
                    InputImperialValue();
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

        public string OutputBame()
        {
            StringBuilder message = new StringBuilder("\n");
            message.Append("\n\tIf you are Black, Asian or other minority");
            message.Append("ethnic groups, you have a higher risk!");
            message.Append("\n\tAdults 23.0 or more are at increased risk;");
            message.Append("Adults 27.5 or more are at high risk.");
            return message.ToString();
        }

        public string OutputBmiCategory()
        {
            StringBuilder message = new StringBuilder("\n");

            if (BmiIndex < Underweight)
            {
                message.Append($"Your BMI is {BmiIndex:0.00}, " + $"You are classified as Underweight.");
            }
            else if (BmiIndex >= Underweight && BmiIndex <= Normal)
            {
                message.Append($"Your BMI is {BmiIndex:0.00}, " + $"You are classified as Normal");
            }
            else if (BmiIndex >= Normal && BmiIndex <= Overweight)
            {
                message.Append($"Your BMI is {BmiIndex:0.00}, " + $"You are classified as Overweight");
            }
            else if (BmiIndex >= Overweight && BmiIndex <= ObeseClassI)
            {
                message.Append($"Your BMI is {BmiIndex:0.00}, " + $"You are classified as Obese Class I");
            }
            else if (BmiIndex >= ObeseClassI && BmiIndex <= ObeseClassII)
            {
                message.Append($"Your BMI is {BmiIndex:0.00}, " + $"You are classified as Obese Class II");
            }
            else if (BmiIndex >= ObeseClassIII)
            {
                message.Append($"Your BMI is {BmiIndex:0.00}, " + $"You are classified as Obese Class III");
            }
            return message.ToString();
        }


        private void InputImperialValue()
        {
            Console.WriteLine("\nEnter your Height:");
            Feet = (int)ConsoleHelper.InputNumber("--in Feet > ");
            Inch = (int)ConsoleHelper.InputNumber("--in Inches > ");
            Console.WriteLine("\nEnter your Weight:");
            Stone = (int)ConsoleHelper.InputNumber("--in Stones > ");
            Pound = (int)ConsoleHelper.InputNumber("--in Pounds > ");
        }

        private void InputMetricValue()
        {
            Kilograms = ConsoleHelper.InputNumber("\nEnter your weight to the nearest Kg > ");
            Centimetres = (int)ConsoleHelper.InputNumber("\nEnter your height to the nearest centimeters > ");
        }

        public void CalculateImperial()
        {
            Pound += Stone * POUNDS_IN_STONES;
            Inch += Feet * INCH_IN_FEET;
            BmiIndex = (double)Pound * 703 / (Inch * Inch); 
        }

        public void CalculateMetric()
        {
            Metres = (double)Centimetres / 100;
            BmiIndex = Kilograms / (Metres * Metres);
        }
    }
}
