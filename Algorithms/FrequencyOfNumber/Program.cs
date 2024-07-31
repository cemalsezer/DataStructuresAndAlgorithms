
namespace FrequencyOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[1, 2, 3, 5, 6, 7, 1, 2, 3, 8, 1, 10]
            /*
             1'den 10'a kadar dönüp
            Elimizdeki listeyi kontrol etmeliyiz.
            1' den 10' a kadar kapsamındaki sayıların kaç kez geçtiğini bir kütüphande toplamalıyız.
             */
            List<int> nums = new List<int>() { 1, 2, 3, 5, 6, 7, 1, 2, 3, 8, 1, 10 };
            FrequencyOfNumber(nums);

        }

        private static void FrequencyOfNumber(List<int> nums)
        {
            Dictionary<int,int> frequency = new Dictionary<int,int>();
            for (int i = 1; i <= 10; i++)
            {
                frequency[i] = 0;  // Başlangıçta her sayının frekansı 0 olarak ayarlanır
            }

            foreach (int num in nums)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
            }

            foreach (KeyValuePair<int, int> items in frequency)
            {
                Console.WriteLine(items.Key+" : "+items.Value);
            }
        }
    }
}
