
namespace SumSquareOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Input:
            Dizi: [1, 2, 3, 4, 5]

            Output:
            Yeni Dizi: [1, 4, 9, 16, 25]
            Toplam: 55

             */
            int[] nums = {1,2, 3, 4, 5}; 
            SumOfSquare(nums);
            
        }

        private static void SumOfSquare(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int resultEven = 0;
            int resultOdd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i]= arr[i] * arr[i];
                if (newArr[i]%2==0)
                {
                     resultEven += newArr[i];    

                }
                else
                {
                    resultOdd += newArr[i];
                }
                Console.Write(newArr[i]+" ");
            }
                Console.WriteLine("\nTek Sayıların toplamı: "+resultOdd);
                Console.WriteLine("\nÇift Sayıların toplamı: "+resultEven);
        }
    }
}
