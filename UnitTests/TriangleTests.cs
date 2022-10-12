using FigureArea;

namespace UnitTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void UnitTriangleTest(){
        double tolerance = 1e-6;
        var triangle = new Triangle(1, 1, 1);
        Assert.IsTrue(Math.Abs(0.433012701892219 - triangle.Area()) < tolerance);
        triangle = new Triangle(1, 1, Math.Sqrt(2));
        Assert.IsTrue(Math.Abs(0.5 - triangle.Area()) < tolerance);
    }

    [TestMethod]
    public void RightTriangleTest(){
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.CheckRightTriangle());
    }

    public void NotRightTriangleTest(){
        var triangle = new Triangle(3, 4, 6);
        Assert.IsFalse(triangle.CheckRightTriangle());
    }

    [TestMethod]
    public void NegativeSideTest(){
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, -1));
    }

    [TestMethod]
    public void TriangleInequalityTest(){
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, 3));
    }
}