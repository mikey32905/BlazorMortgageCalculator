namespace BlazorMortgageCalculator.Models
{
    public class LoanPayment
    {
        public int Month { get; set; }
        public double Payment { get; set; }
        public double MonthlyPrinciple { get; set; }
        public double MonthlyInterest { get; set; }
        public double TotalInterest { get; set; }
        public double Balance { get; set; }

    }
}
