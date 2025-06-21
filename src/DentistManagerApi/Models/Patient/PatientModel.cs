using DentistManagerApi.Models.Attendance;
using DentistManagerApi.Models.Person;

namespace DentistManagerApi.Models.Patient;

public class PatientModel : PersonModel
{
    public List<AttendanceModel> Attendances { get; set; }
    
}