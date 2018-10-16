using System;

namespace Week1b_oefening_boten
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ship ship = new Ship("Druppie")
            {
                Speed = 40
            };
            ship.Steer("North");

            Ship speedboat = new SpeedBoat("Druppie")
            {
                Speed = 40
            };
            speedboat.Steer("North");
        }
    }
}
