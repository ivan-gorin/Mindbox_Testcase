using FigureArea;

namespace UnitTests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void UnitCircleTest(){
        var circle = new Circle(0, 0, 1);
        Assert.AreEqual(Math.PI, circle.Area());
    }

    [TestMethod]
    public void NegativeRadiusTest(){
        Assert.ThrowsException<ArgumentException>(() => new Circle(0, 0, -1));
    }
}