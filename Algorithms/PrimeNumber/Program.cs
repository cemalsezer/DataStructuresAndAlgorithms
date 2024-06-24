namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool result = IsPrime.IsNumberPrime(5);
            Console.WriteLine(result == true ? "Num is prime" : "Num is not prime");

        }
    }
}
