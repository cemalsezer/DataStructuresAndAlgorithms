namespace TwoSum
{
    internal partial class Program
    {
        /*
            Example 1:

            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].


        1. Hedef sayıyı sağlayan kombinasyon var mı?
        2. Hedef sayıyı sağlayan kombinasyonun indeksleri?
            int[] arr = {1, 2, 3, 4, 5, };
            
         */
        public class Solution
        {
            public static int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }

            }
            return null;
        }
        }
    }
}
