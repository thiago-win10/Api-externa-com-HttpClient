using AutoMapper;
using IntegraBasil.Application.Integration.Response;
using IntegraBasil.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraBasil.Application.Mappings
{
    public class BankMapping : Profile
    {
        public BankMapping()
        {
            CreateMap(typeof(GenericResponse<>), typeof(GenericResponse<>));
            CreateMap<BankVm, BankResponse>();
            CreateMap<BankResponse, BankVm>();
        }

    }
}
