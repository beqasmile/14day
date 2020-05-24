using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public class Driver
    {
        private static int DriverCounter = 10000;
        private string id;
        private EnumLisencseType licenseType;
        private int age;
        private string driverName;
        private string driverFamily;

        public Driver (EnumLisencseType lisencseType, String driverName)
        {
            this.id = Driver.DriverCounter.ToString();
            Driver.DriverCounter++;
        }

        public string DriverFamily { get => driverFamily; set => driverFamily = value; }
        public string Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        internal EnumLisencseType LicenseType { get => licenseType; set => licenseType = value; }
    }
}
