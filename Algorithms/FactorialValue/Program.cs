

namespace FactorialValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Girilen bir sayının faktöriyel değerini hesaplayan program

                5! = 5 * 4 * 3 * 2 * 1
                4! = 4! * 3!
                3! = 3! * 2!
                0! = 1

                n! = n * n-1
             */

            //Console.WriteLine(FactorialValue(3));

            FactorialValue2(0);
            
        }

        private static void FactorialValue2(int v)
        {
            int result = 1;

            for(int i = 1; i <= v; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        //private static int FactorialValue(int enteredValue)
        //{

        //    int result = 1;

        //    if (enteredValue == 1 && enteredValue == 0)
        //    {
        //        Console.WriteLine(1);
        //    }
        //    else if(enteredValue > 1)
        //    {
        //        for(int i = 2; i<=enteredValue;i++)
        //        {   
        //            result = enteredValue * FactorialValue(enteredValue - 1);                  
        //        }
        //    }

        //    return result;
        //}
    }
}
