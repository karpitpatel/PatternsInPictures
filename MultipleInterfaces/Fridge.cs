using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public class Fridge : IFridge
    {
        bool _isPlugged = false;
        public bool IsPlugged
        {
            get => _isPlugged;

            set
            {
                if (_isPlugged == value)
                    return;

                _isPlugged = value;

                RealTemperature = IsPlugged ? SetTemperature : 0;
            }
        }

        double _setTemperature = double.NaN;
        public double SetTemperature
        {
            get => _setTemperature;

            set
            {
                if (_setTemperature == value)
                    return;

                _setTemperature = value;

                RealTemperature = IsPlugged ? SetTemperature : 0;
            }
        }

        double _realTemperature = 0;
        public double RealTemperature
        {
            get => _realTemperature;
            private set
            {
                if (_realTemperature == value)
                    return;

                _realTemperature = value;

                Console.WriteLine($"Real Temperature is {RealTemperature} degrees");
            }
        }
    }
}
