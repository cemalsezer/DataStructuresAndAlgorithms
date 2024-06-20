using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class StackExamples
    {
        public static void StepExamples()
        {
            Console.Write("Pls enter to a num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            var numStack = new Stack<int>();
            
            while(num > 0)
            {
                int k = num % 10;
                numStack.Push(k);
                num = num / 10;
            }
            int i = 0;
            int n = numStack.Count - 1;
            foreach (var item in numStack)
            {
                Console.WriteLine($"{item} * {Math.Pow(10,n-i)} = {item*Math.Pow(10,n-i)}");
                i++;

            }
        }
    }
}
