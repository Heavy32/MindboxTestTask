using SquareCalculatorFactoryVersion.Figures;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators.SquareCalculatorFactories
{
    public class SquareCalculatorFactory : ISquareCalculatorFactory
    {
        public ISquareCalculator<TFigure> Create<TFigure>() where TFigure : IFigure
        {
            if (typeof(TFigure) == typeof(Triangle))
            {
                return new TriangleSquareCalculator() as ISquareCalculator<TFigure>;
            }
            else if(typeof(TFigure) == typeof(Circle))
            {
                return new CircleSquareCalculator() as ISquareCalculator<TFigure>;
            }
            else
            {
                throw new FigureNotFoundException("there is no figure found to calculate its square");
            }

            return default;
        }
    }
}
