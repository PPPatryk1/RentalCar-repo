using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar
{
    class Contract
    {
        public int contractID { get; set; }
        public int carID { get; set; }
        public int customerID { get; set; }
        public int placeID { get; set; }
        public DateTime startDay { get; set; }
        public DateTime finishDay { get; set; }
        public int totalPrice { get; set; }
    }
}
