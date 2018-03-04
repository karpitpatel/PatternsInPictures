﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPluginSample
{
    // IMouse interface
    public interface IMouse
    {
        double X { get; set; }
        double Y { get; set; }

        void LeftButtonClick();
    }
}
