using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    public class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
           
            if (OnDuty) Console.WriteLine("On Duty : Yes");
            else Console.WriteLine("On Duty : No");

            Console.WriteLine("Number Off Passenger : {0}", NumPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }
    }
}
