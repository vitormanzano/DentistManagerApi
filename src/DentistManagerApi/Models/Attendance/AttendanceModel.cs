using DentistManagerApi.Enums;
using DentistManagerApi.Models.Dentist;
using DentistManagerApi.Models.Patient;

namespace DentistManagerApi.Models.Attendance;

public class AttendanceModel
{
    public Guid Id { get; private init; }
    public string Description { get; set; }
    public string AttendanceType { get; set; }
    public AttendanceStatus Status { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
    public Guid PatientId { get; set; }
    public PatientModel Patient { get; set; }
    public Guid DentistId { get; set; }
    public DentistModel Dentist { get; set; }
}