using System;
using FizzBuzzServices;

namespace ConsoleApp
{
    class Program
    {
        private static readonly FizzBuzzer fizzBuzzer = new FizzBuzzer();

        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(fizzBuzzer.GetValue(i));
            }
            Console.ReadLine();
        }
    }
}
