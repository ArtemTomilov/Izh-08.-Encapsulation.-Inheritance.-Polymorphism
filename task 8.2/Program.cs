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
            Circle C1 = new Circle();

            C1.Radius = 5.26;
            C1.Area();
            C1.Perimeter();
            
            Triangle T1 = new Triangle();

            T1.Side1 = 2.0;
            T1.Side2 = 3.0;
            T1.Side3 = 4.0;
            T1.Area();
            T1.Perimeter();

            Square S1 = new Square();

            S1.Side = 2.0;
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
