using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(10,20,"Green");

          
            Console.WriteLine($"Color: {cylinder.getColor()}");
            Console.WriteLine($"Height: {cylinder.getHeight()}");
            Console.WriteLine($"Radius: {cylinder.getRadius()}");

            cylinder.setColor("Yellow");
            cylinder.setHeight(50);
            cylinder.setRadius(100);

    
            Console.WriteLine($"Color: {cylinder.getColor()}");
            Console.WriteLine($"Height: {cylinder.getHeight()}");
            Console.WriteLine($"Radius: {cylinder.getRadius()}");

            Console.WriteLine($"\nArea of the cylinder: {cylinder.getArea()}");
            Console.WriteLine($"Volume of the cylinder: {cylinder.getVolume()}");

            Console.WriteLine($"\nString representation of the cylinder: {cylinder.toString()}");

            Console.ReadLine();

        }
    }
}
