using AutoMapper;
using BankingCreditSystem.Application.Features.CorporateCustomers.Dtos.Responses;
using BankingCreditSystem.Application.Features.CorporateCustomers.Rules;
using BankingCreditSystem.Application.Services.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Features.CorporateCustomers.Queries.GetById
{
    public class GetByIdCorporateCustomerQuery : IRequest<CorporateCustomerResponse>
    {
        public Guid Id { get; set; }

        public class GetByIdCorporateCustomerQueryHandler : IRequestHandler<GetByIdCorporateCustomerQuery, CorporateCustomerResponse>
        {
            private readonly ICorporateCustomerRepository _corporateCustomerRepository;
            private readonly IMapper _mapper;
            private readonly CorporateCustomerBusinessRules _businessRules;

            public GetByIdCorporateCustomerQueryHandler(
                ICorporateCustomerRepository corporateCustomerRepository,
                IMapper mapper,
                CorporateCustomerBusinessRules businessRules)
            {
                _corporateCustomerRepository = corporateCustomerRepository;
                _mapper = mapper;
                _businessRules = businessRules;
            }

            public async Task<CorporateCustomerResponse> Handle(GetByIdCorporateCustomerQuery request, CancellationToken cancellationToken)
            {
                await _businessRules.CustomerShouldExistWhenRequested(request.Id);

                var customer = await _corporateCustomerRepository.GetAsync(c => c.Id == request.Id);
                return _mapper.Map<CorporateCustomerResponse>(customer);
            }
        }
    }
}
