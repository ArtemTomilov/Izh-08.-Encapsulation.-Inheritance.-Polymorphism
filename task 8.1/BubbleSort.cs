using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izh_08.Encapsulation
{
    public abstract class BubbleSort
    {
        public int[,] ArrayNumber { get; set; }
        public int[,] ResultSort;
        
        public abstract void ThisSort();
    }

    public class DescendingSumLines : BubbleSort
    {
        public override void ThisSort()
        {
            for (int q = 0; q < ArrayNumber.GetLength(0); q++)
            {
                for (int i = 1; i < ArrayNumber.GetLength(0); i++)
                {
                    int sum1 = 0;
                    for (int j = 0; j < ArrayNumber.GetLength(1); j++)
                    {
                        sum1 += ArrayNumber[i - 1, j];
                    }
                    int sum2 = 0;
                    for (int j = 0; j < ArrayNumber.GetLength(1); j++)
                    {
                        sum2 += ArrayNumber[i, j];
                    }
                    if (sum1 > sum2)
                    {
                        for (int w = 0; w < ArrayNumber.GetLength(1); w++)
                        {
                            int buffer = ArrayNumber[i, w];
                            ArrayNumber[i, w] = ArrayNumber[i - 1, w];
                            ArrayNumber[i - 1, w] = buffer;
                        }
                    }
                }
                ResultSort = ArrayNumber;
            }
        }
    }

    public class AscendingSumLines : BubbleSort
    {
        public override void ThisSort()
        {
            for (int q = 0; q < ArrayNumber.GetLength(0); q++)
            {
                for (int i = 1; i < ArrayNumber.GetLength(0); i++)
                {
                    int sum1 = 0;
                    for (int j = 0; j < ArrayNumber.GetLength(1); j++)
                    {
                        sum1 += ArrayNumber[i - 1, j];
                    }
                    int sum2 = 0;
                    for (int j = 0; j < ArrayNumber.GetLength(1); j++)
                    {
                        sum2 += ArrayNumber[i, j];
                    }
                    if (sum1 < sum2)
                    {
                        for (int w = 0; w < ArrayNumber.GetLength(1); w++)
                        {
                            int buffer = ArrayNumber[i, w];
                            ArrayNumber[i, w] = ArrayNumber[i - 1, w];
                            ArrayNumber[i - 1, w] = buffer;
                        }
                    }
                }
            }
            ResultSort = ArrayNumber;
        }
    }

    public class DescendingMaxNumber : BubbleSort
    {
        public override void ThisSort()
        {
            for (int q = 0; q < ArrayNumber.GetLength(0); q++)
            {
                for (int i = 1; i < ArrayNumber.GetLength(0); i++)
                {
                    int max1 = ArrayNumber[i - 1, 0];
                    for (int j = 1; j < ArrayNumber.GetLength(1); j++)
                    {
                        if (max1 < ArrayNumber[i - 1, j])
                        {
                            max1 = ArrayNumber[i - 1, j];
                        }
                    }
                    int max2 = ArrayNumber[i, 0];
                    for (int j = 1; j < ArrayNumber.GetLength(1); j++)
                    {
                        if (max2 < ArrayNumber[i, j])
                        {
                            max2 = ArrayNumber[i, j];
                        }
                    }
                    if (max1 > max2)
                    {
                        for (int w = 0; w < ArrayNumber.GetLength(1); w++)
                        {
                            int buffer = ArrayNumber[i, w];
                            ArrayNumber[i, w] = ArrayNumber[i - 1, w];
                            ArrayNumber[i - 1, w] = buffer;
                        }
                    }
                }
            }
            ResultSort = ArrayNumber;
        }
    }

    public class AscendingMinNumber : BubbleSort
    {
        public override void ThisSort()
        {
            for (int q = 0; q < ArrayNumber.GetLength(0); q++)
            {
                for (int i = 1; i < ArrayNumber.GetLength(0); i++)
                {
                    int min1 = ArrayNumber[i - 1, 0];
                    for (int j = 1; j < ArrayNumber.GetLength(1); j++)
                    {
                        if (min1 > ArrayNumber[i - 1, j])
                        {
                            min1 = ArrayNumber[i - 1, j];
                        }
                    }
                    int min2 = ArrayNumber[i, 0];
                    for (int j = 1; j < ArrayNumber.GetLength(1); j++)
                    {
                        if (min2 > ArrayNumber[i, j])
                        {
                            min2 = ArrayNumber[i, j];
                        }
                    }
                    if (min1 > min2)
                    {
                        for (int w = 0; w < ArrayNumber.GetLength(1); w++)
                        {
                            int buffer = ArrayNumber[i, w];
                            ArrayNumber[i, w] = ArrayNumber[i - 1, w];
                            ArrayNumber[i - 1, w] = buffer;
                        }
                    }
                }
            }
            ResultSort = ArrayNumber;
        }
    }

    public class DescendingMinNumber : BubbleSort
    {
        public override void ThisSort()
        {
            for (int q = 0; q < ArrayNumber.GetLength(0); q++)
            {
                for (int i = 1; i < ArrayNumber.GetLength(0); i++)
                {
                    int min1 = ArrayNumber[i - 1, 0];
                    for (int j = 1; j < ArrayNumber.GetLength(1); j++)
                    {
                        if (min1 > ArrayNumber[i - 1, j])
                        {
                            min1 = ArrayNumber[i - 1, j];
                        }
                    }
                    int min2 = ArrayNumber[i, 0];
                    for (int j = 1; j < ArrayNumber.GetLength(1); j++)
                    {
                        if (min2 > ArrayNumber[i, j])
                        {
                            min2 = ArrayNumber[i, j];
                        }
                    }
                    if (min1 < min2)
                    {
                        for (int w = 0; w < ArrayNumber.GetLength(1); w++)
                        {
                            int buffer = ArrayNumber[i, w];
                            ArrayNumber[i, w] = ArrayNumber[i - 1, w];
                            ArrayNumber[i - 1, w] = buffer;
                        }
                    }
                }
            }
            ResultSort = ArrayNumber;
        }
    }
}

