﻿using AutoMapper;
using BankingCreditSystem.Application.Features.CreditApplications.Dtos.Requests;
using BankingCreditSystem.Application.Features.CreditApplications.Dtos.Responses;
using BankingCreditSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Features.CreditApplications.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreditApplication, CreditApplicationResponse>()
                .ForMember(dest => dest.CreditTypeName, opt => opt.MapFrom(src => src.CreditType.Name))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src =>
                    src.Customer.GetType() == typeof(IndividualCustomer)
                        ? $"{((IndividualCustomer)src.Customer).FirstName} {((IndividualCustomer)src.Customer).LastName}"
                        : ((CorporateCustomer)src.Customer).CompanyName));

            CreateMap<CreateCreditApplicationRequest, CreditApplication>();

            CreateMap<Paginate<CreditApplication>, Paginate<CreditApplicationResponse>>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
        }
    }
}
