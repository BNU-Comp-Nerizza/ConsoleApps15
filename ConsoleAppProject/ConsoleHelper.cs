using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {
        public static void OutputHeading(string title)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"\t{title}    ");
            Console.WriteLine("\tby Nerizza Flores       ");
            Console.WriteLine("------------------------------\n");
        }
    }
}
