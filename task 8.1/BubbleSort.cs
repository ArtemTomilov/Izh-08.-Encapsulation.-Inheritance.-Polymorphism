using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izh_08.Encapsulation
{
    public class BubbleSort
    {
        public static int[,] DescendingSumLines(int[,] arrayNumbers)
        {
            for (int q = 0; q < arrayNumbers.GetLength(0); q++)
            {
                for (int i = 1; i < arrayNumbers.GetLength(0); i++)
                {
                    int sum1 = 0;
                    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                    {
                        sum1 += arrayNumbers[i - 1, j];
                    }
                    int sum2 = 0;
                    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                    {
                        sum2 += arrayNumbers[i, j];
                    }
                    if (sum1 > sum2)
                    {
                        for (int w = 0; w < arrayNumbers.GetLength(1); w++)
                        {
                            int buffer = arrayNumbers[i, w];
                            arrayNumbers[i, w] = arrayNumbers[i - 1, w];
                            arrayNumbers[i - 1, w] = buffer;
                        }
                    }
                }

            }
            return arrayNumbers;
        }

        public static int[,] AscendingSumLines(int[,] arrayNumbers)
        {
            for (int q = 0; q < arrayNumbers.GetLength(0); q++)
            {
                for (int i = 1; i < arrayNumbers.GetLength(0); i++)
                {
                    int sum1 = 0;
                    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                    {
                        sum1 += arrayNumbers[i - 1, j];
                    }
                    int sum2 = 0;
                    for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                    {
                        sum2 += arrayNumbers[i, j];
                    }
                    if (sum1 < sum2)
                    {
                        for (int w = 0; w < arrayNumbers.GetLength(1); w++)
                        {
                            int buffer = arrayNumbers[i, w];
                            arrayNumbers[i, w] = arrayNumbers[i - 1, w];
                            arrayNumbers[i - 1, w] = buffer;
                        }
                    }
                }

            }
            return arrayNumbers;
        }

        public static int[,] AscendingMaxNumber(int[,] arrayNumbers)
        {
            for (int q = 0; q < arrayNumbers.GetLength(0); q++)
            {
                for (int i = 1; i < arrayNumbers.GetLength(0); i++)
                {
                    int max1 = arrayNumbers[i - 1, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (max1 < arrayNumbers[i - 1, j])
                        {
                            max1 = arrayNumbers[i - 1, j];
                        }
                    }
                    int max2 = arrayNumbers[i, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (max2 < arrayNumbers[i, j])
                        {
                            max2 = arrayNumbers[i, j];
                        }
                    }
                    if (max1 < max2)
                    {
                        for (int w = 0; w < arrayNumbers.GetLength(1); w++)
                        {
                            int buffer = arrayNumbers[i, w];
                            arrayNumbers[i, w] = arrayNumbers[i - 1, w];
                            arrayNumbers[i - 1, w] = buffer;
                        }
                    }
                }

            }
            return arrayNumbers;
        }

        public static int[,] DescendingMaxNumber(int[,] arrayNumbers)
        {
            for (int q = 0; q < arrayNumbers.GetLength(0); q++)
            {
                for (int i = 1; i < arrayNumbers.GetLength(0); i++)
                {
                    int max1 = arrayNumbers[i - 1, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (max1 < arrayNumbers[i - 1, j])
                        {
                            max1 = arrayNumbers[i - 1, j];
                        }
                    }
                    int max2 = arrayNumbers[i, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (max2 < arrayNumbers[i, j])
                        {
                            max2 = arrayNumbers[i, j];
                        }
                    }
                    if (max1 > max2)
                    {
                        for (int w = 0; w < arrayNumbers.GetLength(1); w++)
                        {
                            int buffer = arrayNumbers[i, w];
                            arrayNumbers[i, w] = arrayNumbers[i - 1, w];
                            arrayNumbers[i - 1, w] = buffer;
                        }
                    }
                }

            }
            return arrayNumbers;
        }

        public static int[,] AscendingMinNumber(int[,] arrayNumbers)
        {
            for (int q = 0; q < arrayNumbers.GetLength(0); q++)
            {
                for (int i = 1; i < arrayNumbers.GetLength(0); i++)
                {
                    int min1 = arrayNumbers[i - 1, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (min1 > arrayNumbers[i - 1, j])
                        {
                            min1 = arrayNumbers[i - 1, j];
                        }
                    }
                    int min2 = arrayNumbers[i, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (min2 > arrayNumbers[i, j])
                        {
                            min2 = arrayNumbers[i, j];
                        }
                    }
                    if (min1 > min2)
                    {
                        for (int w = 0; w < arrayNumbers.GetLength(1); w++)
                        {
                            int buffer = arrayNumbers[i, w];
                            arrayNumbers[i, w] = arrayNumbers[i - 1, w];
                            arrayNumbers[i - 1, w] = buffer;
                        }
                    }
                }

            }
            return arrayNumbers;
        }

        public static int[,] DescendingMinNumber(int[,] arrayNumbers)
        {
            for (int q = 0; q < arrayNumbers.GetLength(0); q++)
            {
                for (int i = 1; i < arrayNumbers.GetLength(0); i++)
                {
                    int min1 = arrayNumbers[i - 1, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (min1 > arrayNumbers[i - 1, j])
                        {
                            min1 = arrayNumbers[i - 1, j];
                        }
                    }
                    int min2 = arrayNumbers[i, 0];
                    for (int j = 1; j < arrayNumbers.GetLength(1); j++)
                    {
                        if (min2 > arrayNumbers[i, j])
                        {
                            min2 = arrayNumbers[i, j];
                        }
                    }
                    if (min1 < min2)
                    {
                        for (int w = 0; w < arrayNumbers.GetLength(1); w++)
                        {
                            int buffer = arrayNumbers[i, w];
                            arrayNumbers[i, w] = arrayNumbers[i - 1, w];
                            arrayNumbers[i - 1, w] = buffer;
                        }
                    }
                }

            }
            return arrayNumbers;
        }
    }
}

