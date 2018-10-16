using System;
using Week2b_polymorphism;

namespace Week2b_repositories
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car car = new Car
            {
                Id = 1
            };
            Car new_car = new Car
            {
                Id = 2
            };
            RepoOfType<Car>.Create(car);
            RepoOfType<Car>.Create(new_car);
        }
    }
}
