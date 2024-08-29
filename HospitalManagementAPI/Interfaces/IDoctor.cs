using HospitalManagementAPI.Entities;

namespace HospitalManagementAPI.Interfaces
{
    public interface IDoctor
    {
        int Id { get; set; }
        string Specialty { get; set; }
        Department Department { get; set; }
        List<Appointment> Appointments { get; set; }
    }
}
