using HospitalManagementAPI.Entities;

namespace HospitalManagementAPI.Interfaces
{
    public interface IPatient
    {
        int Id { get; set; }
        List<Appointment> Appointments { get; set; }
        List<Hospitalization> Hospitalizations { get; set; }
        List<Treatment> Treatments { get; set; }
    }
}
