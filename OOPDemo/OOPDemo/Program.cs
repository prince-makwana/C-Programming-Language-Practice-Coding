using System;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation
            //Car myCarObject = new Car(1500);
            //myCarObject.Make = "Toyota";
            //myCarObject.Model = "Camry LT";
            //myCarObject.Year = 2020;
            //myCarObject.Color = "Red";

            //myCarObject.Run(65);
            //Console.WriteLine($"My car has make - {myCarObject.Make}, Model - {myCarObject.Model}, " +
            //    $"Engine - {myCarObject.Engine}");

            // Inheritance
            AutomaticTransmission myAutomaticCarObject = new AutomaticTransmission(1500);
            myAutomaticCarObject.Make = "Toyota";
            myAutomaticCarObject.Model = "Camry LT";
            myAutomaticCarObject.Year = 2019;
            myAutomaticCarObject.Color = "White";
            myAutomaticCarObject.changeGear();
            myAutomaticCarObject.Run(65);
            Console.WriteLine($"My car has make - {myAutomaticCarObject.Make}, Model - {myAutomaticCarObject.Model}, " +
                $"Engine - {myAutomaticCarObject.Engine}");

            // Abstraction
            ManualTransmission myManualCarObject = new ManualTransmission(2000);
            myManualCarObject.Make = "Toyota";
            myManualCarObject.Model = "Camry XLT";
            myManualCarObject.Year = 2019;
            myManualCarObject.Color = "White";

            myManualCarObject.Run(65);
            myManualCarObject.changeGear();
            Console.WriteLine($"My car has make - {myManualCarObject.Make}, Model - {myManualCarObject.Model}, " +
                $"Engine - {myManualCarObject.Engine}");

            // Polymorphism

            Car car;
            Console.WriteLine("Enter 1 for Automatic Transmission Car and 2 for Manual Transmission Car: ");
            int enteredValue = Convert.ToInt32(Console.ReadLine());

            if (enteredValue == 1)
            {
                car = new AutomaticTransmission();
            }
            else
            {
                car = new ManualTransmission();
            }

            car.changeGear();

            IConvertibleCar convertibleCar = new AutomaticTransmission();
            convertibleCar.changeRoofTop();

            IConvertibleCar convertibleCar1 = new AutomaticTransmission();
            convertibleCar1.changeRoofTop();
        }
    }
}
