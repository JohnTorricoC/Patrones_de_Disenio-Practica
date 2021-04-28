using System;
using System.Collections.Generic;
using System.Text;

namespace Peripherals_Factory
{
    public class Keyboard : IPeripherals
    {
        public void trademark()
        {
            Console.WriteLine("The keyboard is 'Corsair'");
        }
    }
}
