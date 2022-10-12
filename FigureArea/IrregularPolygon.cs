namespace FigureArea;
public class IrregularPolygon : FigureArea.BaseFigure {
    public List<Point> Points;
    public IrregularPolygon(params Point[] points) {
        Points = points.ToList();
        Check();
    }

    protected override void Check() {}

    public override double Area()
    {
        double result = 0;
        for (int i = 0; i < Points.Count; i++) {
            int j = (i + 1) % Points.Count;
            result += Points[i].X * Points[j].Y - Points[j].X * Points[i].Y;
        }
        return Math.Abs(result) / 2;
    }
}
