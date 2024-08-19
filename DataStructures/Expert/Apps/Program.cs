namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new DataStructures.Array.Array<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            Console.WriteLine($"{arr.Count} - {arr.Capacity}");
        }
    }
}
