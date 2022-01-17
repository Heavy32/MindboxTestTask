namespace LogicInFigureVersion
{
    public class Calculator : ICalculator
    {
        public double GetSquare<T>(T figure) where T : ISquareCalculatedFigure
        {
            return figure.Square;
        }
    }
}
