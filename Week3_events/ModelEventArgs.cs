namespace Week3_events
{
    public class ModelEventArgs
    {
        public int Number { get; set; }

        public ModelEventArgs(int number)
        {
            Number = number;
        }
    }
}