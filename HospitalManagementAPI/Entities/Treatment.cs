namespace HospitalManagementAPI.Entities
{
    public class Treatment
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public List<Patient> Patients { get; set; }


        public Treatment() { 
        
            Patients = new List<Patient>();
        
        }

    }
}
