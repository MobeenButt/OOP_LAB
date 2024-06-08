using System;

namespace ConsoleApp1
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;

        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setCadence(int cardence)
        {
            this.cadence = cardence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void applyBreak(int decrement)
        {
            speed = speed - decrement;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed} \t\t Gear: {gear} \t\t Cadence: {cadence} ");
        }
    }
}
