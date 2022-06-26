

using FigureLibrary;

namespace FigureTest;

public class Tests
{
    private Triangle _triangle1;
    private Triangle _triangle2;
    private Triangle _triangle3;
    private Triangle _triangle4;
    [SetUp]
    public void Setup()
    {
        _triangle1 = new Triangle(3, 4, 5);
        _triangle2 = new Triangle(8, 8, 5);
        _triangle3 = new Triangle(3, 4, 10000);
        _triangle4 = new Triangle(-3, -4, -5);

    }

    [Test]
    public void RightSides()
    {
        Assert.That(_triangle1.CalculateSquare(), Is.EqualTo(6.0));
    }

    [Test]
    public void Pifagor()
    {
        Assert.That(_triangle1.CheckTriangle(), Is.EqualTo(true));
        Assert.That(_triangle2.CheckTriangle(), Is.EqualTo(false));
    }
    
    [Test]
    public void WrongSide()
    {
        Assert.Throws<ArgumentException>(() => _triangle3.CheckData());
        Assert.Throws<ArgumentException>(() => _triangle4.CheckData());
    }

    [Test]
    public void CheckPifagor()
    {
        Assert.That(_triangle1.CheckTriangle, Is.EqualTo(true));
        Assert.That(_triangle2.CheckTriangle, Is.EqualTo(false));
    }
}