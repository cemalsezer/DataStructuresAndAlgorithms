using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisWriter
{
    public class MatrisWriter
    {
        public static void MatrisWriterGen(int[,] x)
        {
            for(int i = 0; i<x.GetLength(0);i++)
            {
                for(int j = 0; j<x.GetLength(1); j++)
                {
                    Console.Write("{0,5}", x[i,j]);
                }
                Console.WriteLine();
            }
        }
        public static void MatrisWriterGen(int[] x)
        {
            Console.WriteLine("\n ");
            for (int i = 0; i < x.Length; i++)
            {
                 Console.Write("{0,5}", x[i]);  
            }
        }

        public static void MatrisWriterGen(string[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write("{0,5}", x[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
