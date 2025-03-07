using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Features.IndividualCustomers.Dtos.Responses
{
    public class DeletedIndividualCustomerResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = default!;
    }
}
