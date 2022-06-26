namespace FigureLibrary;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        
        _radius = radius;
    }

    public void CheckData()
    {
        if (_radius <= 0)
        {
            throw new ArgumentException("Радиус не может быть отрицательным или равняться нулю!");
        }
    }

    public double CalculateSquare()
    {
        CheckData();
        return Math.PI * _radius * _radius;
    }
}