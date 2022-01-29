using System;
using Car;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperCar car = new SuperCar();
            car.start();
            car.stop();
        }
    }
}