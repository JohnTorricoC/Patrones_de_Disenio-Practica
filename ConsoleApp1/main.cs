using System;

namespace Peripherals_Factory
{
    public class main
    {
        static void Main(string[] args)
        {
            PeripheralsFactory factory = new ConcretePeripheralsFactory();

            IPeripherals keyboard = factory.GetPeripherals("Keyboard");
            keyboard.trademark();

            IPeripherals mouse = factory.GetPeripherals("Mouse");
            mouse.trademark();

        }

    }
}
