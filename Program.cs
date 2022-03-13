using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number to check even or odd: ");
            int num = int.Parse(Console.ReadLine());
            if (num%2== 0)
            {
                Console.WriteLine("The given number " + num + " Is even");
            }
            else
            {
                Console.WriteLine("The given number " + num + " Is Odd");
            }
        }

        public static void Main(string[] args)
        {
            Program.EvenOdd();
        }
    }
}
