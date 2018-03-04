using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginSample
{
    public class Baby
    {
        ISuccable _succablePlugin = null;

        // set the succable plugin
        public void SetSuccablePlugin(ISuccable succablePlugin)
        {
            _succablePlugin = succablePlugin;
        }

        // method suck - call the corresponing
        // plugin method
        public void Suck()
        {
            _succablePlugin?.Suck();
        }
    }
}
