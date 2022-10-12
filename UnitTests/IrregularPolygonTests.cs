using FigureArea;

namespace UnitTests;

[TestClass]
public class IrregularPolygonTests
{
    [TestMethod]
    public void UnitPolygonTest(){
        double tolerance = 1e-6;
        var square = new IrregularPolygon(new Point[] {new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1)});
        Assert.IsTrue(Math.Abs(1 - square.Area()) < tolerance);
        var triangle = new IrregularPolygon(new Point[] {new Point(0, 0), new Point(1, 0), new Point(0, 1)});
        Assert.IsTrue(Math.Abs(0.5 - triangle.Area()) < tolerance);

    }
}