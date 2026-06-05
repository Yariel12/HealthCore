using AutoMapper;
using MediatR;
using HealthCore.Application.Features.Patients.DTOs;
using HealthCore.Application.Interfaces;
using HealthCore.Domain.Entities;

namespace HealthCore.Application.Features.Patients.Commands.CreatePatient;

public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, PatientDto>
{
    private readonly IPatientRepository _repository;
    private readonly IMapper _mapper;

    public CreatePatientCommandHandler(IPatientRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<PatientDto> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
    {
        var patient = _mapper.Map<Patient>(request.Dto);
        patient.Id = Guid.NewGuid();

        await _repository.AddAsync(patient);

        return _mapper.Map<PatientDto>(patient);
    }
}