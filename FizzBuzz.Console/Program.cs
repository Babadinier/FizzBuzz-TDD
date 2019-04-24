using FizzBuzz.Services;

namespace FizzBuzz.Console
{
    internal class Program
    {
        private static readonly FizzBuzzerService FizzBuzzerService = new FizzBuzzerService();

        static void Main(string[] args)
        {
            for (var i = 1; i < 100; i++)
            {
                System.Console.WriteLine(FizzBuzzerService.GetValue(i));
            }
            System.Console.ReadLine();
        }
    }
}
