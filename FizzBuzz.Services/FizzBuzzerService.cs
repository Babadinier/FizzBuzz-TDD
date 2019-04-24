namespace FizzBuzz.Services
{
    public class FizzBuzzerService
    {
        public string GetValue(int number)
        {
            var result = string.Empty;
            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result += "Buzz";
            }
            
            return result == string.Empty ? number.ToString() : result;
        }
    }
}
