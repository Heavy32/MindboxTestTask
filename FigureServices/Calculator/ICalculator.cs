using FigureServicesVersion.Figures;

namespace FigureServicesVersion.Calculator
{
    public interface ICalculator<TFigure> where TFigure : IFigure
    {
        double GetSquare(TFigure figure);
    }
}
