using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    public class AutomaticTransmission : Car, IConvertibleCar
    {
        public AutomaticTransmission()
        {
            Console.WriteLine("AutomaticTransmission Constructor.");
        }

        public AutomaticTransmission(int engine) : base(engine)
        {
            
        }

        public override void changeGear()
        {
            Console.WriteLine($"Gear changes automatically.");
        }

        public bool changeRoofTop()
        {
            Console.WriteLine("Toggled Roof in Automatic Car");
            return true;
        }

        public override void Run(int speed)
        {
            base.Run(speed);
            Console.WriteLine($"Car is running with Automatic Transmission.");
        }
    }
}
