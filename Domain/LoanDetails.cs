using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class LoanDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanDetailsId {get; set;}
        public DateTime NoteDate {get; set;}
        public DateTime LoanBoardDate {get; set;}
        public int NoteRatePercentage {get; set;}
        public bool Escrow {get; set;}
        public int TaxAndInsuranceAmount {get; set;}
        public int TotalLoanAmount {get; set;}
        public int LoanTerm {get; set;}
        public string LoanType {get; set;}
        public string LoanFrequency {get; set;}
        public string PropertyAddress {get; set;}
        public ICollection<BorrowerDetails> borrowerDetailList {get; set;}
    }
}