using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._2
{
    abstract class GeometricFigure
    {

        public double S;
        public double P;
        
        public abstract void Area();
        public abstract void Perimeter();
    }

    class Circle : GeometricFigure
    {
        public const double Pi = 3.14159265358979;

        public double Radius { get; set; }
        
        public override void Area()
        {
           S = Pi * (Radius*Radius);
        }
        public override void Perimeter()
        {
            P = 2 * Pi * Radius;
        }
    }

    class Triangle : GeometricFigure
    {

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public override void Area()
        {
            double Half_P = (Side1 + Side2 + Side3) / 2;
            S = Math.Sqrt(Half_P * (Half_P - Side1) * (Half_P - Side2) * (Half_P - Side3));
        }
        public override void Perimeter()
        {
            P = Side1 + Side2 + Side3;
        }
    }



    class Rectangle : GeometricFigure
    { 
        public double Width { get; set; }
        public double Height { get; set; }

        public override void Area()
        {
            S = Width * Height;
            Console.WriteLine(S);
        }
        public override void Perimeter()
        {
            P = (Width+Height) * 2;
            Console.WriteLine(P);
        }
    }

    class Square:Rectangle
    {
        
    }
}
