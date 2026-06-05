using MediatR;
using HealthCore.Application.Features.Patients.DTOs;

namespace HealthCore.Application.Features.Patients.Commands.UpdatePatient;

public record UpdatePatientCommand(Guid Id, UpdatePatientDto Dto) : IRequest<PatientDto>;