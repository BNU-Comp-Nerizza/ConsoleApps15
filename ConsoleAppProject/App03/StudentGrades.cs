using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        //constants
        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;

        //properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        ///<summary>
        ///Class Constructor called when an object
        ///is created and sets up an array of students
        ///</summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                 "Jaco", "Kaira", "Hazel", "Ivy", "Diana",
                "Warren", "Albert", "Amie", "Chloe", "Oggy"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Ouput the heading and 
        /// display the menu
        /// </summary>
        public void StudentMenu()
        {
            ConsoleHelper.OutputHeading("Student Marks Application");
            SelectMenu("Please enter your choice > ");
        }

        /// <summary>
        /// 
        /// </summary>
        private void SelectMenu(string prompt)
        {
            string[] choices =
            {
                "Input Marks",
                "Ouput Marks",
                "Output Stats",
                "Ouput Grade Profile",
                "Quit"
            };
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            ExecuteMenu(choiceNo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="choiceNo"></param>
        private void ExecuteMenu(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    InputMarks();
                    break;
                case 2:
                    OutputMarks();
                    break;
                case 3:
                    CalculateStats();
                    OutputStats();
                    break;
                case 4:
                    CalculateGradeProfile();
                    OutputGradeProfile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    SelectMenu("Please enter your choice > ");
                    break;           
            }
        }

        /// <summary>
        /// Input a mark between 0 - 100 for each student and store
        /// it in the Marks array
        /// </summary>
        public void InputMarks()
        {
            Console.WriteLine("\nPlease enter a mark for each student.\n");

            for (int i=0; i<Students.Length; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($"Enter {Students[i]} marks: ", LowestMark, HighestMark);
            }

            Console.WriteLine();
            SelectMenu("\nPlease enter your choice > ");
        }

        /// <summary>
        /// List all the student and display
        /// their name and current mark
        /// </summary>
        public void OutputMarks()
        {
            Console.WriteLine("\nOutput mark for each student.\n");

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Student Name: {Students[i]} \nStudent Mark: {Marks[i]}\nStudent Grade: {ConvertToGrade(Marks[i])}\n");
            }

            SelectMenu("\n\nPlease enter your choice > ");
        }

        /// <summary>
        /// Calculate a student mark to a grade
        /// from F(fail) to A(First Class)
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            else
            {
                return Grades.F;
            }
        }

        /// <summary>
        /// Calculate and display the minimum, maximum
        /// and mean mark for all the student
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];
            
            double total = 0;

            foreach(int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }
                total += mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Calculate percentage of students 
        /// that obtained the grade
        /// </summary>
        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.D;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
            SelectMenu("\n\nPlease enter your choice > ");
        }

        /// <summary>
        /// 
        /// </summary>
        public void OutputStats()
        {
            Console.WriteLine("\nOutput the Statistics of marks\n");
            Console.WriteLine($"Mean Mark: {Mean}\nMinimum Mark: {Minimum}\nMaximum Mark:{Maximum}");
            Console.WriteLine();
            SelectMenu("\n\nPlease enter your choice > ");
        }
    }
}
