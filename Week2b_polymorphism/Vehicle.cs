namespace Week2b_polymorphism
{
    public class Vehicle : IModel<int>
    {
        public int Id
        {
            get;
            set;
        }

        public override string ToString() => string.Format("Vehicle");
    }
}
