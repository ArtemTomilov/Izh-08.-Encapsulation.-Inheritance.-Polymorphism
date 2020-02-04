using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._3
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] arr1 = { 0, 8, 0, 0, 12 };
            double[] arr2 = { 0, 8, 0, 0, 13 };

            Polynom p1 = new Polynom(arr1);
            Polynom p2 = new Polynom(arr2);


                Console.WriteLine(p1==p2);


            Console.ReadLine();
        }
    }
}
