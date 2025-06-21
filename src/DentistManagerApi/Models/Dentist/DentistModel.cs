using DentistManagerApi.Models.Patient;
using DentistManagerApi.Models.Person;
using DentistManagerApi.Models.Schedule;

namespace DentistManagerApi.Models.Dentist;

public class DentistModel : PersonModel
{
    public string Password { get; set; }
    public List<PatientModel> Patients { get; set; }
    public Guid ScheduleId { get; set; }
    public ScheduleModel Schedule { get; set; }
}