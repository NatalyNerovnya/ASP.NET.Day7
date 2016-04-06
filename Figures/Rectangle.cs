using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle
    {
        private double sideA, sideB;

        public double SideA 
        {
            get { return sideA; }
            set
            {
                if(value < 0)
                    throw new ArgumentException();
                sideA = value;
            }
        }

        public Rectangle()
        {

        }
    }
}
