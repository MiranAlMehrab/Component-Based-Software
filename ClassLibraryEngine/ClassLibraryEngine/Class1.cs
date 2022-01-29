using System;

namespace Engine
{
    interface IEngine
    {
        public void start();
        public void stop();
        public void accelarate();
        public void slowDown();
        public void hitBreak();
    }

    public class CarEngine : IEngine
    {
        public void start()
        {
            Console.WriteLine("Starting engine ...");
        }
        public void stop()
        {
            Console.WriteLine("Stopping engine ...");
        }
        public void accelarate()
        {
            Console.WriteLine("Accelarating ...");
        }
        public void slowDown()
        {
            Console.WriteLine("Slowing down ...");
        }
        public void hitBreak()
        {
            Console.WriteLine("Hitting break, fasten your seatbelt ...");
        }
    }
}