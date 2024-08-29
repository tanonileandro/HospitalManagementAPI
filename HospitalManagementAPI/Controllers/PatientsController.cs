using HospitalManagementAPI.Interfaces;
using HospitalManagementAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private static List<Patient> patients = new List<Patient>();

        [HttpGet]
        public ActionResult<IEnumerable<Patient>> GetPatients()
        {
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public ActionResult<Patient> GetPatient(int id)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);

            if (patient == null)
            {
                return NotFound("Paciente no encontrado.");
            }

            return Ok(patient);
        }

        [HttpPost]
        public ActionResult<Patient> PostPatient(Patient patient)
        {
            patients.Add(patient);
            return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient);
        }

        [HttpPut("{id}")]
        public IActionResult PutPatient(int id, Patient updatedPatient)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);

            if (patient == null)
            {
                return NotFound("Paciente no encontrado.");
            }

            patient.FirstName = updatedPatient.FirstName;
            patient.LastName = updatedPatient.LastName;
            patient.BirthDate = updatedPatient.BirthDate;
            patient.Address = updatedPatient.Address;
            patient.PhoneNumber = updatedPatient.PhoneNumber;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePatient(int id)
        {
            var patient = patients.FirstOrDefault(p => p.Id == id);

            if (patient == null)
            {
                return NotFound("Paciente no encontrado.");
            }

            patients.Remove(patient);
            return NoContent();
        }
    }
}
