namespace HospitalManagementAPI.Entities
{
    public class Hospitalization
    {

        public int Id { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public Patient Patient { get; set; }
        public Room Room { get; set; }

    }
}
