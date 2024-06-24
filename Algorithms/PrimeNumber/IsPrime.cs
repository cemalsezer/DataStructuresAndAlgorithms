using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class IsPrime
    {
        public static bool IsNumberPrime(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("The samllest prime number is 2");
                return false;
            }
           
            bool primeControl = true;
            for(int i=2; i<n; i++)
            {
                if (n % i == 0)
                {
                    primeControl = false;
                    break;
                }
            }
            return primeControl;
        }
    }
}
