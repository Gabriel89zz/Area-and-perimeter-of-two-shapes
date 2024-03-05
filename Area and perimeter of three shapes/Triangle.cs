using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_perimeter_of_two_shapes
{
    internal class Triangle:Shape
    {

        public Triangle():base()
        {
                
        }

        public override double GetArea()
        {
            return (height * basefigure)/2;
        }

        public override double GetPerimeter()
        {
            return basefigure*3;
        }
    }
}
