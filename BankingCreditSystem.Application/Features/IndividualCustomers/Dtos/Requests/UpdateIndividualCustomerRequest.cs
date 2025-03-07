using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Features.IndividualCustomers.Dtos.Requests
{
    public class UpdateIndividualCustomerRequest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Address { get; set; } = default!;
        public string? MotherName { get; set; }
        public string? FatherName { get; set; }
    }
}
