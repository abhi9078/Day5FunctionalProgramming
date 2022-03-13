using System;

namespace Day5FunctionalProblem
{
    internal class Program
    {
        public static void VowelOrConsonant()
        {
            Console.WriteLine("Enter a Alphabet");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is a Consonant");
                    break;
            }

        }

        public static void Main(string[] args)
        {
            Program.VowelOrConsonant();
        }
    }
}
