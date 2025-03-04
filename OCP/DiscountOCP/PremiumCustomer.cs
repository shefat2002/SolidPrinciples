namespace OCP.DiscountOCP
{
    public class PremiumCustomer : IDiscountStrategy
    {
        public double CalculateDiscount(double amount) => amount * .2;
    }
}
