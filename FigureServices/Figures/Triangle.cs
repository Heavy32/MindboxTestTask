namespace FigureServicesVersion.Figures
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        public double A { get; init; }
        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double B { get; init; }
        /// <summary>
        /// Третья сторона
        /// </summary>
        public double C { get; init; }
    }
}
