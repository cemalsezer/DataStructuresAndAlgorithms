
namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindFibonacciSeries(10);
        }

        private static void FindFibonacciSeries(int targetNum)
        {
            int firstNum = 0;
            int secondNum = 1;
            int totalNum = 0;

            for (int i = 0; i < targetNum; i++)
            {
                Console.Write($"{firstNum} ");
                totalNum = firstNum + secondNum;  
                firstNum = secondNum;
                secondNum = totalNum;
            }
        }
    }
}
