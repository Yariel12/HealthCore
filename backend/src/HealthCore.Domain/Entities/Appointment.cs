using HealthCore.Domain.Common;

namespace HealthCore.Domain.Entities;

public class Appointment : BaseEntity
{
    public Guid PatientId { get; set; }

    public Guid DoctorId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string Reason { get; set; } = string.Empty;

    public string Status { get; set; } = "Pending";
}