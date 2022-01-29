using System;
using Engine;
using Light;

namespace Car
{
    interface ICar
    {
        public void start();
        public void stop();
    }

    public class SuperCar : ICar
    {

        CarLight light = new CarLight();
        CarEngine engine = new CarEngine();
        public void start()
        {
            light.turnOn();
            engine.start();
        }
        public void stop()
        {
            engine.stop();
            light.turnOff();
        }
    }
}