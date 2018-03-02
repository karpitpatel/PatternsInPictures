using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public interface ITemperatureSetter
    {
        // the temperature set by hand
        double SetTemperature { get; set; }

        // the real fridge temperature
        double RealTemperature { get; }
    }
}
