using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Services.Repositories
{
    public interface ICreditTypeRepository : IAsyncRepository<CreditType, Guid>
    {
        Task<IList<CreditType>> GetByCustomerTypeAsync(CustomerType customerType);
        Task<IList<CreditType>> GetSubCreditTypesAsync(Guid parentCreditTypeId);
    }
}
