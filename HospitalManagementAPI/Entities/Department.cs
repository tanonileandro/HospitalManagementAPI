namespace HospitalManagementAPI.Entities
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }

        public Department() { 
        
            Doctors = new List<Doctor>();

        }

    }
}
