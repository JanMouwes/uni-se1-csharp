using System;

namespace Week2b_polymorphism
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle boat = new Boat();

            Console.WriteLine($"{vehicle.ToString()}");
            Console.WriteLine($"{car.ToString()}");
            Console.WriteLine($"{boat.ToString()}");
        }
    }
}
