using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izh_08.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
                {
                {0,1,2,4,188 },
                {22,69,51,7,1 },
                {4,44,54,31,2 },
                {21,99,3,5,33 }

            };

            int[,] result1 = BubbleSort.DescendingSumLines(arr);

            for (int i = 0; i < result1.GetLength(0); i++)
            {

                for (int j = 0; j < result1.GetLength(1); j++)
                {
                    Console.Write(result1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
