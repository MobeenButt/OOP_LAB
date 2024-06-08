using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike m=new MountainBike(100,10,50,4);
            m.ShowInfo();
            m.applyBreak(10);
            m.speedUp(200);
            m.setGear(3);
            m.setCadence(6);
            m.setSeatHeight(5);
            m.ShowInfo();

            Console.ReadKey();

        }
    }
}
