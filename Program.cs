using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void QuotientAndReminder()
        {
            int q, r;
            Console.WriteLine("Please Enter a Divinded:");
            int divi=int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Divisor: ");
            int div=int.Parse(Console.ReadLine());
            q = divi / div;
            r = divi % div;
            Console.WriteLine("The Quotient is: " + q);
            Console.WriteLine("The Reminder is: "+ r);
        }

        public static void Main(string[] args)
        {
            Program.QuotientAndReminder();
        }
    }
}
