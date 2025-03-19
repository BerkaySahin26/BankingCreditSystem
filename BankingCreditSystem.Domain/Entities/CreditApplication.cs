using BankingCreditSystem.Core.Repositories;
using BankingCreditSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCreditSystem.Domain.Entities
{
    public class CreditApplication : Entity<Guid>
    {
        public Guid CreditTypeId { get; set; }
        public Guid CustomerId { get; set; }
        public decimal RequestedAmount { get; set; }
        public int RequestedTerm { get; set; } 
        public decimal ApprovedAmount { get; set; }
        public int ApprovedTerm { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal TotalPayment { get; set; }
        public CreditApplicationStatus Status { get; set; } 
        public string? RejectionReason { get; set; }

        public virtual CreditType CreditType { get; set; } = default!;
        public virtual Customer Customer { get; set; } = default!;
    }
}
