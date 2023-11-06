namespace ShapesLibrary.Interfaces
{
    public interface ITriangle : IShape
    {
        double Radius { get; }
        bool IsRight { get; }
    }
}
