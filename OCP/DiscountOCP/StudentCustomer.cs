namespace OCP.DiscountOCP
{
    public class StudentCustomer : IDiscountStrategy
    {
        public double CalculateDiscount(double amount) => amount * .15;
    }
}
