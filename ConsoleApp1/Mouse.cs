using System;
using System.Collections.Generic;
using System.Text;

namespace Peripherals_Factory
{
    public class Mouse : IPeripherals
    {
        public void trademark()
        {
            Console.WriteLine("The mouse is 'Logitech'");
        }
    }
}