using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta.Models;

namespace Vezeeta.Models
{
    public enum Status { pending, completed, canceled }
    public class Booking
    {
        public int BookingID { get; set; }
        public string patientID { get; set; }
        public Client Patient
        { get; set; }

        public string DoctorID { get; set; }
        public Docter Doctor { get; set; }

        public int? DiscountId { get; set; } // Nullable foreign key
        public Discount Discount { get; set; }

        // final price after discount is to be calculated here 
        public float FinalPrice { get; set; }

        public int TimeSlotID { get; set; }
        public TimeSlot timeslot {  get; set; }
        public Status BookingStatus { get; set; }



    }
}
