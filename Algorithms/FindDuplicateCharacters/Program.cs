namespace FindDuplicateCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            string input1 = "happy";
            string input2 = "improper";

            Console.WriteLine(FindDuplicateCharacters(input1)); // Output: "p"
            Console.WriteLine(FindDuplicateCharacters(input2)); // Output: "pr"
        }
        static string FindDuplicateCharacters(string input)
        {
            var charCount = new Dictionary<char, int>();
            var duplicates = new HashSet<char>();
            var result = new List<char>();

            // Count occurrences of each character
            foreach (var ch in input)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount[ch] = 1;
                }
            }

            // Identify duplicates and maintain their first occurrence order
            foreach (var ch in input)
            {
                if (charCount[ch] >= 2 && !duplicates.Contains(ch))
                {
                    duplicates.Add(ch);
                    result.Add(ch);
                }
            }

            return new string(result.ToArray());
        }
    }
}
