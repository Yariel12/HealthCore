using HealthCore.Application.Interfaces;
using MediatR;

namespace HealthCore.Application.Features.Patients.Commands.DeletePatient;
public class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommand, bool>
{
    private readonly IPatientRepository _repository;

    public DeletePatientCommandHandler(IPatientRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
    {
        var patient = await _repository.GetByIdAsync(request.Id)
            ?? throw new KeyNotFoundException($"Patient with id {request.Id} not found");

        await _repository.DeleteAsync(patient.Id);
        return true;
    }
}