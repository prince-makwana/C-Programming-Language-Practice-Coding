using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read only properties
            // Read only vs Constants
            // Object Initializers
            // Partial Classes
            // Protected, Internal and Protected internal access modifiers
            // Class - System.Object Overriding ToString method
            // Static Classes - shared class

            //ShipingBuisnessLogic objShippingBiz = new ShipingBuisnessLogic("Online Shopping");

            //objShippingBiz.OfficeLocation = "San Francisco";
            //objShippingBiz.RegistrationNumber = "CA-1584";

            ShipingBuisnessLogic objShippingBiz = new ShipingBuisnessLogic("Online Shopping") 
            { OfficeLocation = "San Francisco", RegistrationNumber = "CA-1584"};
            Console.WriteLine(objShippingBiz);

            CourierServiceBase courierService = new EagleCourierSouthAmerica();
            Console.WriteLine($"Courier Service: {courierService.CompanyRegistration}");

            courierService.SendItemsByAir("Laptop");

            EagleCourierSouthAmerica objSouthShippingBiz = new EagleCourierSouthAmerica();
            Console.WriteLine($"You may have to pay {objSouthShippingBiz.ProtectionCost()}" +
                $" as item protection cost.\n");

            Console.WriteLine($"Static Class Demo: App Culture {Constants.APP_CULTURE}");

            Helper.LogDetail("Static Class Method Demo");

            Helper.count = 1;
            Print();

            Console.WriteLine($"Shared Count value(from main): {Helper.count}\n");
        }

        static void Print()
        {
            Helper.count++;
            Console.WriteLine($"Shared Count value: {Helper.count}\n");
        }
    }
}
