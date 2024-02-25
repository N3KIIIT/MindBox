using MindBoxGeometryLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxGeometryLib.Figure
{

    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Circle doesn't exist");

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
