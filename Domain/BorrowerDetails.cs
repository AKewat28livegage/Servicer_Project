using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class BorrowerDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public int ServicerLoanId {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public string ContactNumber {get; set;}
        public string ZipCode {get; set;}
        public string MailingAddress {get; set;}
        public string SSN {get; set;}
        public virtual ICollection<LoanDetails> LoanDetailList {get; set;}
    }
}