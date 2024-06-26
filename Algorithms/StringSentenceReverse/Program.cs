

namespace StringSentenceReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "hello world this is test sentence";

            StringSentenceReverse(sentence);
            string result = StringSentenceReverseV2(sentence);
            Console.WriteLine("\nV2: "+result);

        }

        private static string StringSentenceReverseV2(string sentence)
        {
            string[] newSentence = sentence.Split(' ');
            Array.Reverse(newSentence);
            return string.Join(' ', newSentence);

        }

        private static void StringSentenceReverse(string sentence)
        {
            string[] newSentence = sentence.Split(' ');
            Console.Write("V1: ");
            for (int i = newSentence.Length; i>0; i--)
            {
                Console.Write(newSentence[i-1]+" ");
            }          
        }


    }
}
