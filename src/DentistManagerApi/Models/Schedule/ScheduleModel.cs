using DentistManagerApi.Models.Attendance;

namespace DentistManagerApi.Models.Schedule;

public class ScheduleModel
{
    public Guid Id { get; set; }
    public List<AttendanceModel> Attendances { get; set; }
}