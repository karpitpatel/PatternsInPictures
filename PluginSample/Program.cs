using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Baby baby = new Baby();

            Console.WriteLine("Setting succable plugin to passifier");
            baby.SetSuccablePlugin(new Pacifier());

            baby.Suck();

            Console.WriteLine("Setting succable plugin to a BottleWithMilk");
            baby.SetSuccablePlugin(new BottleWithMilk());

            baby.Suck();
        }
    }
}
