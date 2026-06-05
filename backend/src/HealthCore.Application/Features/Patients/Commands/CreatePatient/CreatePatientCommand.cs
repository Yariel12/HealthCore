using MediatR;
using HealthCore.Application.Features.Patients.DTOs;

namespace HealthCore.Application.Features.Patients.Commands.CreatePatient;

public record CreatePatientCommand(CreatePatientDto Dto) : IRequest<PatientDto>;