
namespace SecondBigNumOnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             --> Bir sayı dizisi verildiğinde, dizideki en büyük ikinci sayıyı bulan bir algoritma
             --> array kullanılacak, verilen dizi en az 2 eleman içermeli

             Örnek:

             Girdi: [3, 5, 7, 1, 6]
             Çıktı: 6
             */

            int[] arr = { 32,2,3,12,26 };

            SecondBigNumOnArray(arr);
        }

        private static void SecondBigNumOnArray(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Array should have at least two elements");
                return;
            }

            //List<int> list = new List<int>(arr);
            //var siraliSayilar = list.OrderByDescending(x => x).ToList();
            //int[] newArr = siraliSayilar.ToArray();
            //Console.WriteLine(newArr[1]);


            int first = int.MinValue, second = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            if (second == int.MinValue)
            {
                Console.WriteLine("There is no second largest element in the array.");
            }
            else
            {
                Console.WriteLine("The second largest element is " + second);
            }
        }
    }
}
