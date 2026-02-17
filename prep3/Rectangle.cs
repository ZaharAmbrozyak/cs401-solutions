namespace prep3;

public class Rectangle
{
    private readonly int _width;
    
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        if (_height <= 0 || _width <= 0)
        {
            throw new ArgumentException("Width and height should be positive.");
        }
        _height = height;
        _width = width;
    }

    public int GetArea()
    {
        return _height * _width;
    }
}