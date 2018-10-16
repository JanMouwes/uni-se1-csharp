using System;
namespace Week1b_oefening_boten
{
    public class SpeedBoat : Ship
    {
        public SpeedBoat(string name) : base(name)
        {
        }

        public override void Steer(string direction)
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

            Console.WriteLine($"Steering {direction.ToLower()} very fast");
        }
    }
}

