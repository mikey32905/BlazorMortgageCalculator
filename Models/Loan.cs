using System.ComponentModel.DataAnnotations;

namespace BlazorMortgageCalculator.Models
{
    public class Loan
    {
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Purchase Amount must be at least $1.")]
        public double PurchaseAmount { get; set; }

        [Required]
        [Range(0.0, 100, MinimumIsExclusive = true, ErrorMessage = "Interest Rate must between 0 and 100.")]
        public double Rate { get; set; }

        //Term in expressed in years
        [Required]
        [Range(1, 100, ErrorMessage = "Term must between 1 and 100 years.")]
        public int Term { get; set; }

        public double Payment { get; set; }
        public double TotalInterest { get; set; }

        public double TotalCost { get; set; }

        public List<LoanPayment> Payments { get; set; } = new List<LoanPayment>();
    }
}
