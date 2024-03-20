using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculationService
{
    public interface IFigure
    {
        public string FigureName { get; set; }
        public double FindArea();
    }
}
