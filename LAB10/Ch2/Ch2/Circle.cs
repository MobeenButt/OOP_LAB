using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    internal class Circle
    {
       protected double radius = 1.0;
       protected string color = "red";
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;   
        }
        public Circle(string color,double radius) 
        {
            this.radius=radius;
            this.color = color;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius= radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color) 
        {
            this.color=color;
        }
        public double getArea()
        {
            return (3.41 * (radius)*2);
        }
        public string toString()
        {
            return $"Circle [radius={radius},color={color}]";
        }

    }
}
