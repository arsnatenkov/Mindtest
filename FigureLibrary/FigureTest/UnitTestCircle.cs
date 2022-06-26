using FigureLibrary;

namespace FigureTest;

public class UnitTestCircle
{
    private Circle _circle1;
    private Circle _circle2;
    [SetUp]
    public void Setup()
    {
        _circle1 = new Circle(4);
        _circle2 = new Circle(-1);
    }

    [Test]
    public void RightRadius()
    {
        Assert.That(_circle1.CalculateSquare(), Is.EqualTo(Math.PI * 4 * 4));
    }

    [Test]
    public void CheckRadius()
    {
        Assert.Throws<ArgumentException>(() => _circle2.CheckData());
    }
}