using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void LeapYear()
        {

            Console.WriteLine("Hello, Welcome to Leap Year Problem ");
            Console.WriteLine("Enter year to check: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                Console.WriteLine("This year is a Leap Year");
            }
            else
            {
                Console.WriteLine("Is not a Leap Year");
            }
        }

        public static void Main(string[] args)
        {
            Program.LeapYear();
        }
    }
}
