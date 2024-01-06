using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.ViewModels;

namespace IntegraBasil.Application.Integration.Interfaces
{
    public interface IBankIntegrationService
    {
        Task<GenericResponse<List<BankVm>>> GetAllBanks();
        Task<GenericResponse<BankVm>> GetBankById(string codeBank);


    }
}
