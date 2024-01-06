using IntegraBasil.Application.Integration.Response;

namespace IntegraBasil.Application.Integration.Interfaces
{
    public interface IBrasilApiIntegration
    {
        Task<GenericResponse<AddressResponse>> GetByCep(string cep);
        Task<GenericResponse<List<BankResponse>>> GetAllBanks();
        Task<GenericResponse<BankResponse>> GetBankById(string codeBank);

    }
}
