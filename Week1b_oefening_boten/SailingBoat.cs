using System;
namespace Week1b_oefening_boten
{
    public class SailingBoat : Ship
    {
        private int sailSurfaceArea;
        public int SailSurfaceArea
        {
            get => sailSurfaceArea;
            set => sailSurfaceArea = value;
        }


        public SailingBoat(string name) : base(name)
        {
        }

        public SailingBoat(int speed, int sailSurfaceArea) : this("[No name]")
        {
            Speed = speed;
            SailSurfaceArea = sailSurfaceArea;
        }

        public SailingBoat(int speed) : this(speed, 0)
        {
        }
    }
}
