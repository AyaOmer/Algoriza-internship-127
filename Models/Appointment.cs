using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veezeta.Models;

namespace Vezeeta.Models
{
    public enum WeekDay { Saturday, Sunday, Monday, Tuesday, Wednesday,Thursday, Friday}
    public class Appointment
    {
        // appointment ID
        public int Id { get; set; }
        //doctor 
        public string doctorID { get; set; }
        //doctor object for creating the realtionship 
        public Docter doctor { get; set; }
         

        // day of the appointment
        public WeekDay day {  get; set; }
        // time slots for that one day
        List<TimeSlot> timeSlots { get; set; }


    }
}
