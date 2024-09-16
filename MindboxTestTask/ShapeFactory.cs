using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestTask
{
    public static class ShapeFactory
    {
        public static Shape CreateCircle(double radius) => new Circle(radius);

        public static Shape CreateTriangle(double sideA, double sideB, double sideC) => new Triangle(sideA, sideB, sideC);
    }
}
