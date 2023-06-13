using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mindbox.Geometry.Interfaces;

namespace Mindbox.Geometry.Figures
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }
    }
}
