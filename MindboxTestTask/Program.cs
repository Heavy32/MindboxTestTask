namespace MindboxTestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogicInClass();
            SquareCalculatorFactory();
            FigureServices();
        }

        static void LogicInClass()
        {
            LogicInFigureVersion.Circle circle = new() { Radius = 5 };
            LogicInFigureVersion.ICalculator calculator = new LogicInFigureVersion.Calculator();

            double square = calculator.GetSquare(circle);
        }

        static void SquareCalculatorFactory()
        {
            SquareCalculatorFactoryVersion.Figures.Circle circle = new() {  Radius = 5 };
            SquareCalculatorFactoryVersion.Calculator.SquareCalculators.SquareCalculatorFactories.SquareCalculatorFactory factory = new();
            SquareCalculatorFactoryVersion.Calculator.ICalculator calculator = new SquareCalculatorFactoryVersion.Calculator.Calculator(factory);

            double square = calculator.GetSquare(circle);
        }

        static void FigureServices()
        {
            FigureServicesVersion.Figures.Circle circle = new() { Radius = 5 };
            FigureServicesVersion.Calculator.ICalculator<FigureServicesVersion.Figures.Circle> calculator = new FigureServicesVersion.Calculator.CircleCalculator();

            double square = calculator.GetSquare(circle);
        }
    }
}
