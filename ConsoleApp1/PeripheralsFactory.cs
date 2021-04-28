using System;
using System.Collections.Generic;
using System.Text;

namespace Peripherals_Factory
{
    public abstract class PeripheralsFactory
    {
        public abstract IPeripherals GetPeripherals(string Peripherals);
    }
}
