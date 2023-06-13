using Mindbox.Geometry.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Geometry.Figures
{
    public class Triangle : IFigure
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        private double _sideA;
        private double _sideB;
        private double _sideC;

        /// <summary>
        /// Признак прямоугольности
        /// </summary>
        public bool IsRight
        {
            get
            {
                // Теорема Пифагора
                var sideSquareA = Math.Round(Math.Pow(_sideA, 2), 2);
                var sideSquareB = Math.Round(Math.Pow(_sideB, 2), 2);
                var sideSquareC = Math.Round(Math.Pow(_sideC, 2), 2);

                var isRightA = Math.Abs(sideSquareB + sideSquareC - sideSquareA) < 0.02;
                var isRightB = Math.Abs(sideSquareA + sideSquareC - sideSquareB) < 0.02;
                var isRightC = Math.Abs(sideSquareA + sideSquareB - sideSquareC) < 0.02;

                return isRightA || isRightB || isRightC;
            }
        }

        public double GetArea()
        {
            // Формула Герона
            double p = (_sideA + _sideB + _sideC) / 2;

            return Math.Round(Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC)), 2);
        }
    }
}
