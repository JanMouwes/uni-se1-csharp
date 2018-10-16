using System;

namespace Week3_events
{
    public class DataView
    {
        private int screenNumber;

        public DataView(Model m, int screenNumber)
        {
            this.screenNumber = screenNumber;
            m.Observer += ShowData;
        }

        public void ShowData(object sender, ModelEventArgs eventArgs)
        {
            Model model = (Model) sender;
            Console.WriteLine($"Scherm {screenNumber} meldt: getal gewijzigd: {eventArgs.Number}");
        }
    }
}