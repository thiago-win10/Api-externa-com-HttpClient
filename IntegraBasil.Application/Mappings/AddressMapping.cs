using AutoMapper;
using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.ViewModels;

namespace IntegraBasil.Application.Mappings
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<AddressVm, AddressResponse>();
            CreateMap<AddressResponse, AddressVm>();
        }
    }
}
