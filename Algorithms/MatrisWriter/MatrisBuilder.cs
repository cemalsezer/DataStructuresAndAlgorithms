using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisWriter
{
    public class MatrisBuilder
    {
        public static int[,] MatrisNumsBuilderGen(int row=3, int column=3,int min=1, int max=9)
        {
            int[,] newMatris = new int[row, column];
            for(int i = 0; i < row;i++)
            {
                for(int j = 0; j< column;j++)
                    newMatris[i,j] = new Random().Next(min,max);

            }
            return newMatris;
        }


        public static string[,] MatrisCharBuilderGenV2(int row, int column, char choise)
        {
            string[,] newMatris = new string[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    newMatris[i, j] += choise;
                }
            }
            return newMatris;
        }


        public static int[,] ZeroMatrisBuilderGen(int row, int column)
        {
            return MatrisNumsBuilderGen(row, column,0,0);

        }

        public static int[,] OneMatrisBuilderGen(int row, int column)
        {
            return MatrisNumsBuilderGen(row, column, 1, 1);

        }

        public static int[,] DiagonalMatrixBuilderGen(int len=3, int min=1,int max = 1)
        {
            int[,] x = ZeroMatrisBuilderGen(len, len);
            for(int i = 0; i<x.GetLength(0);i++)
            {
                x[i, i] = new Random().Next(min, max);
            }
            return x;
        }

        public static int[,] SkalerMatrixBuilderGen(int len=3, int skaler=3)
        {
            return DiagonalMatrixBuilderGen(len, skaler, skaler);
        }

        public static bool IsSquareMatrix(int[,] x)
        {
            return x.GetLength(0) == x.GetLength(1) ? true : false;
        }
        public static int[,] UnitMatrixBuilderGen(int len = 3)
        {
            return SkalerMatrixBuilderGen(len,1);
        }
        public static bool IsUnitMatrix(int[,] x)
        {
            bool control = true;
            for(int i = 0; (i < x.GetLength(0) && control==true); i++)
            {
                for(int j = 0; j < x.GetLength(1); j++)
                {
                    if (x[i,j] != 0 && i != j)
                    {
                        control = false;
                        break;
                    }
                    else
                    {
                        if (x[i,i] !=1 && i == j)
                        {
                            control = false;
                            break;
                        }
                    }
                }
            }

            return control;
        }

        public static int[] DiagonalElementList(int[,] x)
        {
            if(IsSquareMatrix(x))
            {
                int[] arr = new int[x.GetLength(0)];
                for(int i = 0; i<x.GetLength(0);i++)
                {
                    arr[i] = x[i, i];
                }
                return arr;
            }
            else
            {
                Console.WriteLine("Pls input the square matrix!");
                return new int[1];
            }
        }

        public static int Shadow(int[,] X)
        {
            int t = 0;
            if(IsSquareMatrix(X))
            {
                int[] arr = DiagonalElementList(X);
                for(int i = 0; i<X.GetLength(0); i++)
                {
                    t += X[i, i];
                }
                return t;
            }
            else
            {
                return t;
            }
        }
        public static int[,] Transpose(int[,] X)
        {
            int[,] T = new int[X.GetLength(1), X.GetLength(0)];
            for(int i =0;i<T.GetLength(0);i++)
            {
                for(int j = 0; j<T.GetLength(1); j++)
                {
                    T[i,j] = X[j, i];
                }
            }
            return T;
        }

        public static int[,] ReShape(int[,] X, int newRow, int newColumn)
        {
            int[] arr = new int[X.Length];
            int counter = 0;
            int[,] newArr = new int[newRow, newColumn];
            for(int i =0; i <X.GetLength(0);i++)
            {
                for (int j = 0; j < X.GetLength(1); j++)
                {
                    arr[counter] = X[i, j];
                    counter++;
                }
            }

            MatrisWriter.MatrisWriterGen(arr);

            counter = 0;
            for(int i = 0; i< newArr.GetLength(0);i++)
            {
                for(int j = 0; j < newColumn; j++)
                {
                    newArr[i, j] = arr[counter];
                    counter++;
                }
            }
            return newArr;
        }
    }
}
