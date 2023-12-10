using Vezeeta.Models;

namespace Veezeta.Models
{
    public class Docter:Client
    {
        public string doctorid { get; set; }
        public float price { get; set; }
        public int specializationID { get; set; }
        public Specialization Specialization { get; set; }
        public List<Appointment> Doctors_Appointments { get; set; }
    }
}
