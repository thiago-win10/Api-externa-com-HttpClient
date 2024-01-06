using AutoMapper;
using IntegraBasil.Application.Integration.Interfaces;
using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.ViewModels;

namespace IntegraBasil.Application.Integration.Services
{
    public class BankIntegrationService : IBankIntegrationService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiIntegration _brasilApiIntegration;

        public BankIntegrationService(IMapper mapper, IBrasilApiIntegration brasilApiIntegration)
        {
            _mapper = mapper;
            _brasilApiIntegration = brasilApiIntegration;
        }

        public async Task<GenericResponse<List<BankVm>>> GetAllBanks()
        {
            var banksAll = await _brasilApiIntegration.GetAllBanks();
            return  _mapper.Map<GenericResponse<List<BankVm>>>(banksAll);
        }

        public async Task<GenericResponse<BankVm>> GetBankById(string codeBank)
        {
            var bank = await _brasilApiIntegration.GetBankById(codeBank);
            return _mapper.Map<GenericResponse<BankVm>>(bank);
        }
    }
}
