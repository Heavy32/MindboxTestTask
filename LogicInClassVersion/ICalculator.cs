namespace LogicInFigureVersion
{
    public interface ICalculator
    {
        double GetSquare<T>(T figure) where T : ISquareCalculatedFigure;
    }
}
