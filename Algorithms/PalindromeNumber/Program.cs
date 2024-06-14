namespace PalindromeNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IsPalindromeChecking(99);
        }

        private static void IsPalindromeChecking(int i)
        {
            int number = i;
            int reverse = 0;
            while (i > 0)
            {
                int remainder = i % 10;
                reverse = reverse * 10 + remainder;
                i = i / 10;
            }

            if (number == reverse)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
    }
}
