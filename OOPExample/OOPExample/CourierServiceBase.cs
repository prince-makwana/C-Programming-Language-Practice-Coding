using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    public abstract class CourierServiceBase
    {
        protected string _companyRegistration;
        public string CompanyRegistration
        {
            get
            {
                if (string.IsNullOrEmpty(_companyRegistration))
                    _companyRegistration = "EAGLE-00";
                return _companyRegistration;
            }
        }
        public abstract void SendItemsByAir(string item);
        public abstract void SendItemsByRoad(string item);

        internal void Packing(string item)
        {
            //Packing
            Console.WriteLine($"Packing {item}");
        }
    }
}
