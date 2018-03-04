using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    public class Computer
    {
        public IMouse Mouse { get; set; }

        public IKeyboard Keyboard { get; set; }

        public Computer()
        {
            Mouse = new PlainMouse();

            Keyboard = new PlainKeyboard();
        }

        public void MoveMouse(double x, double y)
        {
            if (Mouse == null)
                return;

            Mouse.X = x;
            Mouse.Y = y;
        }

        public void MouseClick()
        {
            Mouse?.LeftButtonClick();
        }

        public void ClickKeyboardKey(char c)
        {
            Keyboard?.KeyClick(c);
        }
    }
}
