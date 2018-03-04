using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{    
    // PlainKeyboard
    // mentions PlainKeyboard in its console 
    // messages
    public class PlainKeyboard : IKeyboard
    {
        public void KeyClick(char c)
        {
            Console.WriteLine($"Plain Keyboard clicked '{c}'");
        }
    }
}
