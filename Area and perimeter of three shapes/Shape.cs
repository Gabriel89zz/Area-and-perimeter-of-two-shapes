using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_perimeter_of_two_shapes
{
    abstract class Shape
    {
		protected double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		protected double basefigure;

		public double Base
		{
			get { return basefigure; }
			set { basefigure = value; }
		}

        protected Shape()
        {
	        height = 0;
			basefigure = 0;
        }

		abstract public double GetArea();
        abstract public double GetPerimeter();
    }
}
