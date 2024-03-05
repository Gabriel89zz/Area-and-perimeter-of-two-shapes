using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_perimeter_of_two_shapes
{
    internal class Rectangle:Shape
    {

        public Rectangle():base()
        {
                
        }
        public override double GetArea()
        {
           return height*basefigure;
        }

        public override double GetPerimeter()
        {
            return (height * 2) + (basefigure * 2);
        }
    }
}
