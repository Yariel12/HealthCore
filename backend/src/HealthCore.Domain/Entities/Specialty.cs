using HealthCore.Domain.Common;

namespace HealthCore.Domain.Entities;

public class Specialty : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}