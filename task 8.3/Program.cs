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

            double[] FirstArr = { -81,0,12,1 };
            double[] SecondArr = { 3,1};

            Polynom p1 = new Polynom(FirstArr);
            Polynom p2 = new Polynom(SecondArr);
            Polynom p = p1 / p2;

            Console.WriteLine(p.ToString());

            Console.ReadLine();
        }
    }
}
