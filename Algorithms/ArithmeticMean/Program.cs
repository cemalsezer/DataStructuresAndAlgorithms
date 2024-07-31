
namespace ArithmeticMean
{
    internal class Program : Arithmetic
    {
        static void Main(string[] args)
        {
     
           int[] x = RandomNums.RndNum(3, 10);
           Console.Write($"Your Arithmetic Nums: ");
            foreach (var item in x)
                Console.Write($"{item} ");
            //codereview
            Console.WriteLine($"\nArithmetic Mean of Your Nums: {Arithmetic.ArithmeticMean(x)}");
        }
    }
}
