using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square: Rectangle,IFigure
    {
        #region Constructors
        public Square() : base() { }

        public Square(double a) : base(a, a)
        { }
        #endregion

        #region Public Methods

        public double GetRadiusIncircal()
        {
            return (double) SideA/2;
        }
#endregion
    }

}
