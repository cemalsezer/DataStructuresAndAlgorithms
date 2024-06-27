using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMean
{
    public class RandomNums
    {
        public static int[] RndNum(int numsLen, int numDif)
        {
            int result = 0;
            int[] newNums = new int[numsLen];
            for(int i = 0; i < numsLen; i++)
            {
                newNums[i] = new Random().Next(1,numDif);

            }
            return newNums;
        }
    }
}
