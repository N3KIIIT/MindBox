using MindBoxGeometryLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxGeometryLib.Figure
{
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValid(sideA, sideB, sideC))
                throw new ArgumentException($"Triangle doesn't exist ");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetArea()
        {
            var semiperimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2) ||
                   Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) ||
                   Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2);
        }
        private bool IsValid(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) &&
                   (sideB + sideC > sideA) &&
                   (sideC + sideA > sideB);
        }
    }
}
