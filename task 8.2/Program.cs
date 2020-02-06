using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Square S1 = new Square();

            S1.Width = 2.0;
            S1.Height = 2.0;
            S1.Area();
            S1.Perimeter();


            Rectangle R1 = new Rectangle();
            R1.Width = 2.0;
            R1.Height = 3.0;
            R1.Area();
            R1.Perimeter();
            Console.ReadLine();
        }
    }
}
