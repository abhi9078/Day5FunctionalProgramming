using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void HramonicNumber()
        {
            Console.WriteLine("Welcome to Harmonic Number Problem");
            Console.WriteLine("Please Enter the Range: ");
            int range = int.Parse(Console.ReadLine());
            if (range == 0 || range < 0)
            {
                Console.WriteLine("Please Enter Non-Zero range");
            }
            else
            {

                float result = 0;
                int n = range;
                for (float i = 1; i <= range; i++)
                {
                    result = result + 1 / i;
                }
                Console.WriteLine("Harmonic Number upto the range" + n + "is: " + result);
            }
        }

        public static void Main(string[] args)
        {
            Program.HramonicNumber();
        }
    }
}
