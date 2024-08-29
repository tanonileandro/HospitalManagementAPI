using HospitalManagementAPI.Interfaces;

namespace HospitalManagementAPI.Entities
{
    public class Patient : User, IPatient
    {
        public List<Appointment> Appointments { get; set; }
        public List<Hospitalization> Hospitalizations { get; set; }
        public List<Treatment> Treatments { get; set; }

        public Patient()
        {
            Appointments = new List<Appointment>();
            Hospitalizations = new List<Hospitalization>();
            Treatments = new List<Treatment>();
        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

