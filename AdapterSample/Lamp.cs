using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    public class Lamp : IAmericanPowerPlug
    {
        public bool IsPluggedIntoAmericanPowerOutlet
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
