using FigureAreaCalculationService;

namespace FigureAreaCalc
{
    public class Context
    {
        public IFigure ContextFigure { get; set; }

        public Context(IFigure _figure)
        {
            ContextFigure = _figure;
        }

        public void FindArea()
        {
            ContextFigure.FindArea();
        }
    }

}

