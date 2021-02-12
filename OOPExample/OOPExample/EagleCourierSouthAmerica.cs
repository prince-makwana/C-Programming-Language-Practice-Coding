using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    public partial class EagleCourierSouthAmerica : CourierServiceBase
    {
        public EagleCourierSouthAmerica()
        {
            this._companyRegistration = "EAGLE-S01";
        }

        public override void SendItemsByAir(string item)
        {
            Packing(item);
            //Send it
            Console.WriteLine($"Sending {item}  by air");
        }

        public override void SendItemsByRoad(string item)
        {
            Packing(item);
            Console.WriteLine($"Sending {item} by road");
        }
    }
}
