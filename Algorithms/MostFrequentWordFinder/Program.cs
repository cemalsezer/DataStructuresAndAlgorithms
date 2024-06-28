
namespace MostFrequentWordFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               "Bir metin içindeki en sık tekrar eden kelimeyi bulan bir algoritma yazın."
               Bu soruda, bir metin içinde hangi kelimenin en sık tekrar eden olduğunu bulmak için nasıl bir algoritma geliştireceğinizi düşünmeniz gerekecektir.
               "Bu gün hava güneşli ve sıcak. Bahçede çiçekler açmış, kuşlar cıvıl cıvıl ötüyor. İnsanlar dışarıda piknik yapıyor ve keyifli vakit geçiriyor."
             */
            string sentence = "Bu gün hava güneşli ve ve cıvıl sıcak. Bahçede çiçekler açmış, kuşlar cıvıl cıvıl ötüyor. İnsanlar dışarıda piknik yapıyor ve keyifli vakit geçiriyor.";
            MostFrequentWordFinder(sentence);
        }
        private static void MostFrequentWordFinder(string sentence)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] splitSentence = sentence.Split(' ');
            foreach(var word in splitSentence)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            var maxCount = 0;
            var mostFrequentWord =string.Empty; 
            foreach (var item in dict)
            {
                if (item.Value > maxCount)
                {
                    mostFrequentWord =  item.Key ;
                    maxCount = item.Value;
                }
                else if (item.Value == maxCount)
                {
                    mostFrequentWord = mostFrequentWord + " " + item.Key;
                }
            }
           Console.WriteLine(mostFrequentWord);
        }
    }
}
