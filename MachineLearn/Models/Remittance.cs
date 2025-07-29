namespace ClaimFraudAPI.Models
{
    public class Remittance
    {
        public int Id { get; set; }
        public string ClaimId { get; set; }= null!;
        public string ProviderName { get; set; } = null;
        public decimal RemittanceAmmount { get; set; }
        public DateTime RemittanceDate { get; set; }
        public string? TransactionReference { get; set; }
    }
}
