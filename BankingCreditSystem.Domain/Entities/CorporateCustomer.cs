namespace BankingCreditSystem.Domain.Entities;

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; } = default!;
    public string TaxNumber { get; set; } = default!;
    public string TaxOffice { get; set; } = default!;
    public string CompanyRegistrationNumber { get; set; } = default!; // Ticaret Sicil No
    public DateTime CompanyFoundationDate { get; set; }
    public string AuthorizedPersonName { get; set; } = default!;
} 