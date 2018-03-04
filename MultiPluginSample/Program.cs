using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();

            computer.MoveMouse(20, 50);

            computer.MouseClick();

            computer.ClickKeyboardKey('h');

            computer.Keyboard = new FancyKeyboard();

            computer.ClickKeyboardKey('h');
        }
    }
}
