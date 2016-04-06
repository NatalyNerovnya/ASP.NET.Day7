using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square: Rectangle,IFigure
    {
        public Square() : base() { }

        public Square(double a) : base(a, a)
        { }
    }

}
