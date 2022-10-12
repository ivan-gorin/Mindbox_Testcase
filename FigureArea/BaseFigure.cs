namespace FigureArea;
public abstract class BaseFigure {
    protected abstract void Check();
    public abstract double Area();
}

public struct Point {
    public double X, Y;
    
    public Point(double x, double y) {
        X = x;
        Y = y;
    }
}