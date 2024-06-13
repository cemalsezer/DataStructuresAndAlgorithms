namespace TextSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world this is a test sentence";
            string[] newText = text.Split(' ');

            for (int i = 0; i < newText.Length; i++) {
                newText[i] = char.ToUpper(newText[i][0]) + newText[i].Substring(1);
                
                if (i < newText.Length - 1)
                {
                    Console.Write($"{newText[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{newText[i]}");
                }
            }
        }
    }
}
