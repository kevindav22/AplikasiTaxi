using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("OnDuty : {0}", OnDuty);
            Console.WriteLine("Number Off Passenger : {0}", NumPassenger);


            
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\nJono Sedang Menjemput Penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("Jono Selesai Menjemput Penumpang");

            Console.ReadKey();
        }
   

    }
}
