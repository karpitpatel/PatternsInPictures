using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    public class FancyKeyboard : IKeyboard
    {
        public void KeyClick(char c)
        {
            Console.WriteLine($"Fancy Keyboard clicked '{c}'");
        }
    }
}
