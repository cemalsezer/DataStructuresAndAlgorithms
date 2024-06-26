namespace MaxAndMinNumFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter to length of array: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[answer];
            for(int i = 0; i< answer; i++)
            {
                nums[i] = new Random().Next(1, 7);
                if (i < nums.Length - 1)
                {
                    Console.Write(nums[i]+",");
                }
                else
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine("\n----------------");

            Console.WriteLine("Big num of array: "+BigNum(nums));
            Console.WriteLine("Small num of array: "+SmallNum(nums));
        }

        public static int BigNum(int[] arr)
        {
            int bigOne = arr[0];
            for(int i = 1; i< arr.Length; i++)
            {
                if (arr[i] > bigOne)
                {
                    bigOne = arr[i];
                }
            }
            return bigOne;
        }

        public static int SmallNum(int[] arr)
        {
            int smallOne = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallOne)
                {
                    smallOne = arr[i];
                }
            }
            return smallOne;
        }
    }
}
