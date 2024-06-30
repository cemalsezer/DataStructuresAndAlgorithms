namespace File
{
    public class StreamWriterGen
    {

        public static void StreamWriter()
        {
            try
            {
                string[] url = Directory.GetCurrentDirectory().Split('\\');
                string fileUrl = "";
                for (int i = 0; i < url.Length - 3; i++)
                {
                    fileUrl += url[i] + "\\";
                }
                fileUrl += "Names.txt";

                string[] names = new string[] { "A", "B", "C", "D" };
                using (StreamWriter sw = new StreamWriter(fileUrl))
                {
                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                    Console.WriteLine("\nStreamWriter is Succesfull");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}