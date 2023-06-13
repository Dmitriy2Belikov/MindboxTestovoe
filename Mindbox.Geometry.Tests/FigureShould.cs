using Mindbox.Geometry.Figures;

namespace Mindbox.Geometry.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleAreaShould()
        {
            var circle = new Circle(3.25);

            Assert.AreEqual(33.18, circle.GetArea());
        }

        [Test]
        public void TriangleAreaShould()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.That(triangle.GetArea(), Is.EqualTo(6));
        }

        [Test]
        public void RightTriangleShould()
        {
            var triangleA = new Triangle(3, 4, 5);
            var triangleB = new Triangle(5, 3, 4);
            var triangleC = new Triangle(4, 5, 3);

            Assert.That(triangleA.IsRight, Is.EqualTo(true));
            Assert.That(triangleB.IsRight, Is.EqualTo(true));
            Assert.That(triangleC.IsRight, Is.EqualTo(true));
        }
    }
}