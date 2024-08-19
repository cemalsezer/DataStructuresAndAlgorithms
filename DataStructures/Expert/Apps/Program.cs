using System.Collections;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new DataStructures.Array.Array<int>();

            for (int i = 0; i < 8; i++)
            {
                arr.Add(i + 1);
                Console.WriteLine($"{i + 1} has been added to array.");
                Console.WriteLine($"Count: {arr.Count} / Capacity:{arr.Capacity}");
            }
            Console.WriteLine();

            for (int i=arr.Count;i >=1; i--)
            {
                Console.WriteLine($"{arr.Remove()} has been removed rom the array.");
                Console.WriteLine($"Count: {arr.Count} / Capacity:{arr.Capacity}");
            }

            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
