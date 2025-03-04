namespace OCP.DiscountOCP
{
    public class RegularCustomer : IDiscountStrategy
    {
        public double CalculateDiscount(double amount) => amount * .1;
    }
}
