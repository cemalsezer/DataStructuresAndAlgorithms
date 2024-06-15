using System.Collections;

namespace TwoSum
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            
        int[] arr = { 1, 2, 3, 4 };
        int target = 5;
        int[] result = TwoSum(arr, target);

        if (result != null)
        {
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No pairs found.");
        }

        }

    }

}
