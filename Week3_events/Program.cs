using System;
using System.Xml.Schema;

namespace Week3_events
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model  = new Model();
            
            DataView dataView1 = new DataView(model, 1);
            DataView dataView2 = new DataView(model, 2);
            
            model.EditNumber(3);
        }
    }
}