using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    class ShipingBuisnessLogic
    {
        public const string ORGANIZATION_NAME = "ABC Corp Ltd.";
        private readonly string _departmentName;

        public ShipingBuisnessLogic(string departmentName)
        {
            _departmentName = departmentName;
        }

        public string OfficeLocation { get; set; }
        public string RegistrationNumber { get; set; }

        //System.Object

        public override string ToString()
        {
            return $"Organization - {ORGANIZATION_NAME}\nDepartment - {this._departmentName}\n" +
                $"Office Location - {this.OfficeLocation}\nRegistration Number - {this.RegistrationNumber}\n";
        }
    }
}
