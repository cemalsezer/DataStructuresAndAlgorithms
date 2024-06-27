namespace ArithmeticMean
{
    public class Arithmetic
    {

        public static double ArithmeticMean(int[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return Math.Round(sum / x.Length, 2);
            //return sum / x.Length;
        }
    }
}