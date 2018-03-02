using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    public class AmericanLamp : IAmericanPowerPlug
    {
        bool _isSwitchOn = false;
        public bool IsSwitchOn
        {
            get => _isSwitchOn;
            set
            {
                if (_isSwitchOn == value)
                    return;

                _isSwitchOn = value;

                // set IsOn to be true iff 
                // IsSwitchOn and IsPlugged are true
                IsOn = IsSwitchOn && IsPluggedIntoAmericanPowerOutlet;
            }
        }

        bool _isOn = false;
        public bool IsOn
        {
            get => _isOn;

            set
            {
                if (_isOn == value)
                    return;

                _isOn = value;

                // print to console when IsOn changes
                Console.WriteLine($"The lamp is {(_isOn ? "On" : "Off")}");
            }
        }

        bool _isPluggedIntoAmericanPowerOutlet = false;
        public bool IsPluggedIntoAmericanPowerOutlet
        {
            get => _isPluggedIntoAmericanPowerOutlet;

            set
            {
                if (_isPluggedIntoAmericanPowerOutlet == value)
                    return;

                _isPluggedIntoAmericanPowerOutlet = value;

                // set IsOn to be true iff 
                // IsSwitchOn and IsPlugged are true
                IsOn = IsSwitchOn && IsPluggedIntoAmericanPowerOutlet;
            }
        }
    }
}
