using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    public class EagleCourierNorthAmerica : CourierServiceBase
    {
        public EagleCourierNorthAmerica()
        {
            this._companyRegistration = "EAGLE-N01";
        }
        public override void SendItemsByAir(string item)
        {
            Packing(item);
            //Send it
            Console.WriteLine($"Sending {item} by air");
        }

        public override void SendItemsByRoad(string item)
        {
            Packing(item);
            Console.WriteLine($"Sending {item} by road");
        }
    }
}
