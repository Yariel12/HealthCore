using HealthCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthCore.Infrastructure.Persistence;

public class HealthCoreDbContext : DbContext
{
    public HealthCoreDbContext(DbContextOptions<HealthCoreDbContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Patients => Set<Patient>();

    public DbSet<Doctor> Doctors => Set<Doctor>();

    public DbSet<Specialty> Specialties => Set<Specialty>();

    public DbSet<Appointment> Appointments => Set<Appointment>();
}