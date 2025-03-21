﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Application.Features.IndividualCustomers.Dtos.Responses
{
    public class UpdatedIndividualCustomerResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime UpdatedDate { get; set; }
        public string Message { get; set; } = default!;
    }
}
