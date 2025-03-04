namespace OCP.DiscountOCP
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);
    }
}
