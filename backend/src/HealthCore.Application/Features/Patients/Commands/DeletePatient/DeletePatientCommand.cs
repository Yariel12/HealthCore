using MediatR;

namespace HealthCore.Application.Features.Patients.Commands.DeletePatient;

public record DeletePatientCommand(Guid Id) : IRequest<bool>;