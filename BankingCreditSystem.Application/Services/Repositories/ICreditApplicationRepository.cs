using BankingCreditSystem.Domain.Entities;
using BankingCreditSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Services.Repositories
{
    public interface ICreditApplicationRepository : IAsyncRepository<CreditApplication, Guid>
    {
        Task<IList<CreditApplication>> GetByCustomerIdAsync(Guid customerId);
        Task<IList<CreditApplication>> GetByCreditTypeIdAsync(Guid creditTypeId);
        Task<IList<CreditApplication>> GetByStatusAsync(CreditApplicationStatus status);
    }
}
