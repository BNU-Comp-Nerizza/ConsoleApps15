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
        /// Input a mark between 0 - 100 for each student and store
        /// it in the Marks array
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the student and display
        /// their name and current mark
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
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
            else
            {
                return Grades.A;
            }
        }

        /// <summary>
        /// Calculate and display the minimum, maximum
        /// and mean mark for all the student
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            foreach(int mark in Marks)
            {
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
            throw new NotImplementedException();
        }
    }
}
