using MindboxTestTask;


namespace MindboxTestTaskTests
{
    public class Tests
    {
        [Test]
        public void CircleAreaTest()
        {
            var circle = ShapeFactory.CreateCircle(5);
            double expected = Math.PI * 25;
            Assert.AreEqual(expected, circle.CalculateArea(), 1e-6);
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            double expected = 6; // Площадь прямоугольного треугольника
            Assert.AreEqual(expected, triangle.CalculateArea(), 1e-6);
        }

        [Test]
        public void IsRightAngledTriangleTest()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5) as Triangle;
            Assert.IsNotNull(triangle);
            Assert.IsTrue(triangle.IsRightAngled());
        }


        [Test]
        public void NonRightAngledTriangleTest()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 5, 7) as Triangle; ;
            Assert.IsNotNull(triangle);
            Assert.IsFalse(triangle.IsRightAngled());
        }

    }
}