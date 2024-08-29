using HospitalManagementAPI.Interfaces;

namespace HospitalManagementAPI.Entities
{
    public class Doctor : User, IDoctor
    {
        public string Specialty { get; set; }
        public Department Department { get; set; }
        public List<Appointment> Appointments { get; set; }

        public Doctor()
        {
            Appointments = new List<Appointment>();
        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}