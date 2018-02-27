using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the lamp
            ILamp lamp = new Lamp();

            // plugin the lamp  
            lamp.IsPlugged = true;

            // turn it on 
            // at this point it should print
            // to console that the lamp is on
            lamp.IsSwitchOn = true;

            // create a fridge
            IFridge fridge = new Fridge();

            // set the temperature to 58 degrees
            fridge.SetTemperature = 58d;

            // at this point, it should print 
            // temperature to console. 
            fridge.IsPlugged = true;
        }
    }
}
