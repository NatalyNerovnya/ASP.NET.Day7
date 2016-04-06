using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Double;

namespace Figures
{
    public class Circle : IFigure, IEquatable<Circle>
    {
        #region Private Fields
        private double radius;
        #endregion

        #region Constructors

        public Circle()
        {
            Radius = 1;
        }

        public Circle(double r)
        {
            Radius = r;
        }
        #endregion

        #region Properties
        public double Radius
        {
            get { return radius;}
            private set
            {
                if (IsInfinity(value) || IsNaN(value) || value <= 0.0)
                    throw new ArgumentException();
                radius = value;
            }
        }
        #endregion

        #region Public Methods
        public double Area()
        {
            return PI * Radius * Radius;
        }

        public bool Equals(Circle other)
        {
            if(this == null || other == null)
                throw new ArgumentException();

            if (Radius.Equals(other.Radius))
                return true;
            return false;
        }

        public double Perimeter()
        {
            return 2*PI*Radius;
        }

#endregion
    }
}
