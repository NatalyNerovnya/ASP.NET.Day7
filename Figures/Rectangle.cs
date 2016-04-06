using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle :IFigure, IEquatable<Rectangle>
    {
        #region Fields
        private double sideA, sideB;
        #endregion

        #region Properties
        public double SideA 
        {
            get { return sideA; }
            private set
            {
                if(double.IsInfinity(value) || double.IsNaN(value) || value <= 0)
                    throw new ArgumentException();
                sideA = value;
            }
        }

        public double SideB
        {
            get { return sideB; }
            private set
            {
                if (double.IsInfinity(value) || double.IsNaN(value) || value <= 0)
                    throw new ArgumentException();
                sideB = value;
            }
        }
        #endregion

        #region Constructors
        public Rectangle()
        {
            SideA = 1;
            SideB = 1;
        }

        public Rectangle(double a, double b)
        {
            SideA = a;
            SideB = b;
        }

        #endregion

        #region Public Methods

        public virtual double Area()
        {
            return SideA*SideB;
        }

        public virtual double Perimeter()
        {
            return 2*(SideA + SideB);
        }

        public virtual double GetDiagonal()
        {
            return Math.Pow(SideA*SideA + SideB*SideB, 0.5);
        }

        public virtual double GetRadiusCircumcircle()
        {
            return (double)GetDiagonal()/2;
        }

        public virtual bool Equals(Rectangle other)
        {
            if (other == null || this == null)
                throw new ArgumentNullException();
            return other.SideA.Equals(SideA) && other.SideB.Equals(SideB) ? true : false;
        }

        #endregion
    }
}
