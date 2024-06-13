namespace CharFraquencyAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Verilen bir metin içindeki harflerin frekansını bulan bir C# fonksiyonu nasıl yazarsınız?
             * Fonksiyon, bir metin dizesi alacak ve metindeki her bir harfin kaç kez geçtiğini sayacak şekilde tasarlanmalıdır. 
             * Fonksiyonunuzun büyük-küçük harf duyarlılığı olup olmadığını belirtmek önemlidir. 
             */
            string text = "galatasaray şampiyon oldu"; //m:1 e:1 r:1 h:1 a:2 b:1

            CharFrequencyAnalysis(text);
        }

        private static void CharFrequencyAnalysis(string input)
        {
            input = input.Replace(" ", "");
            var keyValuePairs = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c]++;
                }
                else
                {
                    keyValuePairs.Add(c, 1);
                }
            }

            foreach (var c in keyValuePairs)
            {
                Console.WriteLine($"{c.Key}:{c.Value}");
            }

        }


    }
}
