using DayOfWeek = Vezeeta.Models.WeekDay;

namespace Vezeeta.Presentation.API.Models
{
    public class AddAppointmentDTO
    {
       public string DId { get; set; }
        public float price { get; set; }

        public IDictionary<DayOfWeek, List<TimeSpan>> times { get; set; }


    }
}
