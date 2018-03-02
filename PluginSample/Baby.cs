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

        public void SetSuccablePlugin(ISuccable succablePlugin)
        {
            _succablePlugin = succablePlugin;
        }

        public void Suck()
        {
            _succablePlugin?.Suck();
        }
    }
}
