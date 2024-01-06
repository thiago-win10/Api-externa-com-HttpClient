using AutoMapper;
using IntegraBasil.Application.Integration.Interfaces;
using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.ViewModels;

namespace IntegraBasil.Application.Integration.Services
{
    public class AddressIntegrationService : IAddressIntegrationService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiIntegration _brasilApiIntegration;

        public AddressIntegrationService(IMapper mapper, IBrasilApiIntegration brasilApiIntegration)
        {
            _mapper = mapper;
            _brasilApiIntegration = brasilApiIntegration;
        }

        public async Task<GenericResponse<AddressVm>> GetCep(string cep)
        {
            var address = await _brasilApiIntegration.GetByCep(cep);

            return _mapper.Map<GenericResponse<AddressVm>>(address);

        }

    }
}
