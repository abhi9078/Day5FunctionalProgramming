using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void Factor()
        {
            int fact=1;
            Console.WriteLine("Enter a number to check: ");
            int num=int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of "+num+" is: "+fact);
        }

        public static void Main(string[] args)
        {
            Program.Factor();
        }
    }
}
