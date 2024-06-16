namespace PalindromicSubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PalindromicSubString("aab");
        }
        private static void PalindromicSubString(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++) // i belirli bir değerden başlayarak text.Length'a kadar döner.
            {
                for (int j = i + 1; j <= text.Length; j++) // 
                {
                    string subString = text.Substring(i, j - i); // i'den j'ye kadar olan alt diziyi alır.
                    if (IsPalindrome(subString))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static bool IsPalindrome(string subString)
        {
            int i = 0; // i değeri 0'dan başlar.
            int j = subString.Length - 1; // j değeri subString'in uzunluğundan 1 çıkarılarak başlar. çünkü index 0'dan başlar.
            while (i < j)
            {
                if (subString[i] != subString[j]) // i ve j değerlerine karşılık gelen karakterler eşit değilse false döner.
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
