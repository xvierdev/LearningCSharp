using System;

namespace Exercices
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double P = (A + B + C) / 2.0;
            double area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return area;
        }
    }
}