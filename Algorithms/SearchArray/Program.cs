
namespace SearchArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Bir dizide (array) sadece bir kez geçen elemanı bulunuz. 
                Örneğin, verilen dizi [2, 3, 5, 3, 2, 4, 5] ise, yalnızca bir kez geçen eleman 4'tür. 
                Birden fazla bir kez kullanılmış sayı varsa en küçük olan sayıyı dön.
      
             
             */
            int[] x = {1, 1, 2, 2, 3, 4, 4, 5};

            SearchArray(x);


        }

        private static void SearchArray(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            foreach(var num in arr)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num,1);
                }
            }

            var uniqueKeys = new List<int>();
            foreach(var x in dict)
            {
                if (x.Value == 1)
                {
                    uniqueKeys.Add(x.Key);
                }
            }
            Console.WriteLine(string.Join(", ", uniqueKeys));


        }
    }
}
