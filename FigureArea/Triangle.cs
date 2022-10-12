namespace FigureArea;
public class Triangle : FigureArea.BaseFigure {
    double A, B, C;

    public Triangle(double side1, double side2, double side3) {
        A = side1;
        B = side2;
        C = side3;
        if (A > C) {
            (A, C) = (C, A);
        }
        if (B > C) {
            (B, C) = (C, B);
        }
        Check();
    }

    protected override void Check() {
        if (A <= 0 || B <= 0 || C <= 0) {
            throw new ArgumentException("Sides must be > 0.");
        }
        if (A + B <= C) {
            throw new ArgumentException("Triangle inequality violated.");
        }
    }

    public override double Area()
    {
        double halfPerimeter = (A + B + C) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    public bool CheckRightTriangle() {
        return Math.Abs(A * A + B * B - C * C) < 1e-6;
    }
}
