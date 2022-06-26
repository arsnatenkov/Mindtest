namespace FigureLibrary;

public class Triangle : IFigure
{
    private double _aSide;
    private double _bSide;
    private double _cSide;

    public Triangle(double aSide, double bSide, double cSide)
    {
        
        _aSide = aSide;
        _bSide = bSide;
        _cSide = cSide;
    }

    public void CheckData()
    {
        if (_aSide <= 0 || _bSide <= 0 || _cSide <= 0)
        {
            throw new ArgumentException("Сторона не может быть отрицательной или равняться нулю!");
        }
        if (_aSide + _bSide < _cSide || _aSide + _cSide < _bSide || _bSide + _cSide < _aSide)
        {
            throw new ArgumentException("У треугольника не бывает таких сторон!");
        }
        
    }

    public double CalculateSquare()
    {
        CheckData();
        double halfPerimetr = 0;
        halfPerimetr = (_aSide + _bSide + _cSide) / 2;
        return Math.Sqrt(halfPerimetr * (halfPerimetr - _aSide) * (halfPerimetr - _bSide)
                         * (halfPerimetr - _cSide));
    }

    public bool CheckTriangle()
    {
        CheckData();
        double maxSize = new[] { _aSide, _cSide, _bSide }.Max();
        return Math.Abs(2 * (maxSize * maxSize) - (_aSide * _aSide + _bSide * _bSide + _cSide * _cSide)) == 0;
    }
}