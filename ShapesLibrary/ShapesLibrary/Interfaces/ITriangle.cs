namespace ShapesLibrary.Interfaces
{
    public interface ITriangle : IShape
    {
        double sideA { get; }
        double sideB { get; }
        double sideC { get; }
        bool IsRight { get; }
    }
}
