namespace File
{
    public class StreamReaderGen 
    {
      

        public static void StreamReader()
        {
            try
            {
                string[] url = Directory.GetCurrentDirectory().Split('\\');
                string fileUrl = "";
                for (int i = 0; i < url.Length - 3; i++)
                {
                    fileUrl += url[i] + '\\';
                }
                fileUrl += "Numbers.txt";
                using (var sr = new StreamReader(fileUrl))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}