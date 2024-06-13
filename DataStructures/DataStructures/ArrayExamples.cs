using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ArrayExamples
    {
        public static void ArrayPractice()
        {
            //defined
            int[] nums = new int[] {5,3,8,10,2,18,23,44,55,6,35,19 };
            var numbers = Array.CreateInstance(typeof(int), nums.Length);
            var arr = new ArrayList(nums);


            nums.CopyTo(numbers, 0);
            Array.Sort(nums);
            Array.Sort(numbers);
            Array.Clear(numbers, 2, 2);
            Console.WriteLine(Array.IndexOf(nums,55));
            arr.Sort();

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"nums[{i}] = " +
                    $"{nums[i],3} -" +
                    $"numberss[{i}] = " +
                    $"{numbers.GetValue(i),3}" +
                    $"arr[{i}] = " +
                    $"{arr[i],3}");
            }
        }
    }
}
