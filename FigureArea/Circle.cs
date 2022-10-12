namespace FigureArea;
public class Circle : FigureArea.BaseFigure {
    Point Center;
    double Radius;

    public Circle(double x, double y, double radius) {
        Center = new Point(x, y);
        Radius = radius;
        Check();
    }

    protected override void Check() {
        if (Radius < 0) {
            throw new ArgumentException("Radius must be >= 0.");
        }
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
