using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void SwapTwoNumber()
        {
            Console.WriteLine("Welcome To Swap To Number problem: ");
            Console.WriteLine("Please Enter first Number ");
            int first=int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second number: ");
            int second=int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping First number is: " + first + " and second number is " + second);
            int temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After Swapping First number is: " + first + " and second number is " + second);
        }

        public static void Main(string[] args)
        {
            Program.SwapTwoNumber();
        }
    }
}
