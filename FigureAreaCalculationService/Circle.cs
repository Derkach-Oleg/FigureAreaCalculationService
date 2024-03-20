using FigureAreaCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationService
{
    public class Circle : IFigure
    {
        public string FigureName { get; set; }
        public int radius { get; set; }
        public int Radius
        {
            get { return radius; }
            set
            {
                FigureName = $"Круг с радиусом {value}";
                radius = value;
            }
        }
        public Circle(int radius)
        {
            if(isExist(radius))
            Radius = radius;
        }

        public double FindArea()
        {
            return Math.Round(3.14f * Math.Pow(Radius, 2), 2);
        }
        private bool isExist(int radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Радиус круга должен быть больше 0");
            }
            return true;
        }
    }
}
