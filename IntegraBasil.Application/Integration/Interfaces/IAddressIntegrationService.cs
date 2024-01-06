using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.ViewModels;

namespace IntegraBasil.Application.Integration.Interfaces
{
    public interface IAddressIntegrationService
    {
        Task<GenericResponse<AddressVm>> GetCep(string cep);

    }
}
