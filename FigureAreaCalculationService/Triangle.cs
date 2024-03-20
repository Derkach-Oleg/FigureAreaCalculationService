using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationService
{
    public class Triangle : IFigure
    {
        public string FigureName { get; set; }
        public int edge1 { get; set; }
        public int Edge1
        {
            get { return edge1; }
            set
            {
                edge1 = value;
                SetFigureName();
            }
        }
        public int edge2 { get; set; }
        public int Edge2
        {
            get { return edge2; }
            set
            {
                edge2 = value;
                SetFigureName();
            }
        }
        public int edge3 { get; set; }
        public int Edge3
        {
            get { return edge3; }
            set
            {
                edge3 = value;
                SetFigureName();
            }
        }

        public Triangle(int a, int b, int c)
        {
            if (isExist(a, b, c))
            {   
                Edge1 = a;
                Edge2 = b;
                Edge3 = c;
            }
        }
        //через формулу Герона
        public double FindArea()
        {
            var p = (Edge1 + Edge2 + Edge3) / 2;
            var square = Math.Sqrt(p * (p - Edge1) * (p - Edge2) * (p - Edge3));
            return square;
        }

        private bool isExist(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Все стороны должны быть больше чем 0");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new Exception("Одна из сторон больше суммы двух других)");
            }

            return true;
        }

        public void SetFigureName()
        {
            FigureName = $"Треугольник со сторонами {Edge1}, {Edge2} и {Edge3}";
        }

        public bool isStraightTriangle()
        {
            bool isStraight = (Edge1 == Math.Sqrt(Math.Pow(Edge2, 2) + Math.Pow(Edge3, 2))
                               || Edge2 == Math.Sqrt(Math.Pow(Edge1, 2) + Math.Pow(Edge3, 2))
                               || Edge3 == Math.Sqrt(Math.Pow(Edge1, 2) + Math.Pow(Edge2, 2)));

            return isStraight;
        }
    }
}
