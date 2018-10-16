using System;
using System.Runtime.ConstrainedExecution;

namespace Week3_events
{
    public delegate void Observer(object model, ModelEventArgs eventArgs);

    public class Model
    {
        public event Observer Observer;

        public int Number { get; set; }

        public void AddObserver(Observer obs)
        {
            this.Observer += obs;
        }

        public void EditNumber(int number)
        {
            Number = number;

            Observer?.Invoke(this, new ModelEventArgs(number));
        }

        public int GetNumber()
        {
            return Number;
        }
    }
}