using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Double;

namespace Figures
{
    /// <summary>
    /// Describe Circle
    /// </summary>
    public class Circle : IFigure, IEquatable<Circle>
    {

        #region Private Fields
        private double radius;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor(set radius = 1)
        /// </summary>
        public Circle()
        {
            Radius = 1;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="r">Radius</param>
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
                radius = GoodSide(value);
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Count area 
        /// </summary>
        /// <returns>Area</returns>
        public double Area()
        {
            return PI * Radius * Radius;
        }

        /// <summary>
        /// Compare with other ciercle
        /// </summary>
        /// <param name="other">Second circle</param>
        /// <returns>True, if circles have the same radius</returns>
        public bool Equals(Circle other)
        {
            if(this == null || other == null)
                throw new ArgumentException();

            if (Radius.Equals(other.Radius))
                return true;
            return false;
        }

        /// <summary>
        /// Count circumference
        /// </summary>
        /// <returns>Circumference</returns>
        public double Perimeter()
        {
            return 2*PI*Radius;
        }

        #endregion

        #region Private methods
        /// <summary>
        /// Check the side
        /// </summary>
        /// <param name="a">Side</param>
        /// <returns>Side, if it's ok</returns>
        private double GoodSide(double a)
        {
            if (double.IsNaN(a) || double.IsInfinity(a) || a.Equals(0.0) || a < 0)
                throw new ArgumentException();
            return a;
        }
        #endregion
    }
}
