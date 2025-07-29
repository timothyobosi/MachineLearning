namespace ClaimFraudAPI.Models
{
    public class MedicalClaim
    {
        public int Id { get; set; }
        public string PatientName { get; set; } = null;
        public string MemberNumber { get; set; }
        public string ICD10Code { get; set; } = null;
        public string? DiagnosisDescription { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceDescription { get; set; }
        public string? Encounter { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal LineItemAmount { get; set; }
        public decimal? TotalClaimAmount { get; set; }
        public string? BenefitDescription { get; set; }
        public string? BenefitType { get; set; }
        public string?AdmitId { get; set; }
        public string?Customer { get; set; }
        public string? Scheme { get; set; }
        public string InvoiceNumber { get; set; } = null;
        public DateTime TransactionDate { get; set; }
        public string ProviderName { get; set; } = null;
        public TimeSpan? ServiceTime { get; set; }
        public DateTime? serviceDate { get; set; }
        public decimal? RoamingAmount { get; set; }
        public string ClaimId { get; set; } = null;
        public decimal? PaidAmount { get; set; }
        public string ReconciliationStatus { get; set; } = "Pending";
        public DateTime? PaymentDate { get; set; }

    }
}
