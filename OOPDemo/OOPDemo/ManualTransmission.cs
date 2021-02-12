using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemo
{
    public class ManualTransmission : Car, IConvertibleCar
    {
        public ManualTransmission()
        {
            Console.WriteLine($"ManualTransmission Constructor.");
        }

        public ManualTransmission(int engine) : base(engine)
        {

        }
        public override void changeGear()
        {
            Console.WriteLine("Gear changes manually.");
        }

        public bool changeRoofTop()
        {
            Console.WriteLine("Toggled Roof in Manual Car");
            return true;
        }

        public override void Run(int speed)
        {
            base.Run(speed);
            Console.WriteLine($"Car is running with Automatic Transmission");
        }
    }
}
