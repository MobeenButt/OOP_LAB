using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    internal class Cylinder:Circle
    {
        protected double height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double radius,double height)
        {
            this.height = height;
            this.radius = radius;
        }
        public Cylinder(double height,double radius,string color)
        {
            this.height = height;
            this.radius=radius;
            this.color = color;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height) 
        {
            this.height=height;
        }
        public double getVolume()
        {
            return (radius*height);
        }
    }
}
