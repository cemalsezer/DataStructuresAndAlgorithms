namespace MiniMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            MiniMaxSumGen(arr);
        }

        public static void MiniMaxSumGen(List<int> arr)
        {
            arr.Sort();
            int minValue = arr[0];
            int maxValue = arr[arr.Count - 1];
            int minSum = 0;
            int maxSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (i > 0)
                {
                    maxSum += arr[i];
                }

                if (i < arr.Count - 1)
                {
                    minSum += arr[i];
                }

            }

            Console.Write(minSum + " ");
            Console.Write(maxSum);

            //long miniSum = 0, maxSum = 0, miniNum = arr.Min(), maxNum = arr.Max();
            //foreach (long num in arr)
            //{
            //    if (num >= miniNum && num != maxNum)
            //        miniSum += num;
            //    if (num != miniNum && num <= maxNum)
            //        maxSum += num;
            //}
            //Console.Write(miniSum.ToString() + " " + maxSum.ToString());
        }

    }
}

