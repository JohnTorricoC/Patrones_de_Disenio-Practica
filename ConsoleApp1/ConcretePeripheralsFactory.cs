using System;
using System.Collections.Generic;
using System.Text;

namespace Peripherals_Factory
{
    public class ConcretePeripheralsFactory : PeripheralsFactory
    {
        public override IPeripherals GetPeripherals(string Peripherals)
        {
            switch (Peripherals)
            {
                case "Keyboard":
                    return new Keyboard();
                case "Mouse":
                    return new Mouse();
                default:
                    throw new Exception(string.Format("Peripheral '{0}' cannot be created", Peripherals));
            }
            
        }
    }
}