using System;

namespace Light
{
    interface ILight
    {
        public void turnOn();
        public void turnOff();
        public void blink();
    }

    public class CarLight : ILight
    {
        public void turnOn()
        {
            Console.WriteLine("Light turned on ...");
        }
        public void turnOff()
        {
            Console.WriteLine("Light turned off ...");
        }
        public void blink()
        {
            Console.WriteLine("Light's blinking ...");
        }
    }
}