using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSample
{
    public class Pacifier : ISuccable
    {
        public void Suck()
        {
            Console.WriteLine("Pacifier is sucked");
        }
    }
}
