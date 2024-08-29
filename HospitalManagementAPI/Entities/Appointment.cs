namespace HospitalManagementAPI.Entities
{
    public class Appointment
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

    }
}
