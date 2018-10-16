using System;
using System.Text.RegularExpressions;

namespace Week1b_oefening_boten
{
    public class Ship
    {
        private string name;
        public string Name
        {
            get => name;

            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Name needs to be three or more characters");

                Regex regex = new Regex(@"\s\s");
                if (regex.Match(value).Success)
                    throw new ArgumentException("Name cannot have consecutive spaces");

                name = value;
            }
        }

        private int speed;
        public int Speed
        {
            get => speed;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Speed needs to be positive");

                speed = value;
            }
        }

        public Ship(string name)
        {
            Name = name;
        }

        public virtual void Steer(string direction)
        {
            switch (direction.ToLower())
            {
                case "north":
                case "south":
                case "east":
                case "west":
                    break;
                default:
                    throw new ArgumentException("Direction needs to be north, south, east or west");
            }

            Console.WriteLine($"Steering {direction.ToLower()}");
        }

        public override string ToString()
        {
            return $"The name is {Name} and the speed is {Speed}";
        }
    }
}