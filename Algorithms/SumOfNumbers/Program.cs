
namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 525;
            SumOfNumbers(x);
        }

        private static void SumOfNumbers(int x)
        {
            int sum = 0, num = 0;
            while(x > 0)
            {
                num = x % 10;
                sum += num;
                x /= 10;
            }
            Console.WriteLine("Sum of numbers "+sum);
        }
    }
}
