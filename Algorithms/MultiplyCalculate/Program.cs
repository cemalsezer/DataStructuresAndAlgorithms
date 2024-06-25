
namespace MultiplyCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = {1,2,3,4};

            MultiplyCalculate(myArr);
        }

        private static void MultiplyCalculate(int[] nums)
        {
            int[] newNums = new int[nums.Length];
            int result = 1;
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        result *= nums[j];
                    }
                }
                newNums[i] = result;
                result = 1;

            }

                foreach (int i in newNums)
                {
                    Console.Write(i+" ");
                }
        }
    }
}
