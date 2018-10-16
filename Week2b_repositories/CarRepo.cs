using System;
using Week2b_polymorphism;

namespace Week2b_repositories
{
    [Obsolete]
    public static class CarRepo
    {
        static Car CreateCar(Car car)
        {
            Console.WriteLine($"Car {car.Id} saved to database");
            return car;
        }
        static void DeleteCar(Car car)
        {
            Console.WriteLine($"Car {car.Id} deleted from database");
        }
        static Car UpdateCar(Car car)
        {
            Console.WriteLine($"Car {car.Id} updated in database");
            return car;
        }
    }
    [Obsolete]
    public static class BoatRepo
    {
        static Boat CreateCar(Boat boat)
        {
            Console.WriteLine($"Boat {boat.Id} saved to database");
            return boat;
        }

        static void DeleteCar(Boat boat)
        {
            Console.WriteLine($"Boat {boat.Id} deleted from database");
        }

        static Boat UpdateCar(Boat boat)
        {
            Console.WriteLine($"Boat {boat.Id} updated in database");
            return boat;
        }
    }

    public static class RepoOfType<T> where T : IModel<int>
    {
        public static T Create(T type)
        {
            Console.WriteLine($"{type.GetType().Name} {type.Id} saved to database");
            return type;
        }
        public static void Delete(T type)
        {
            Console.WriteLine($"{type.GetType().Name} {type.Id} deleted from database");
        }
        public static T Update(T type)
        {
            Console.WriteLine($"{type.GetType().Name} {type.Id} updated in database");
            return type;
        }
    }
}
