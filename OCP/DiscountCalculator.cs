using OCP.DiscountOCP;

namespace OCP
{
    //OCP - Violates
    //<------------------------------------------->
    public class DiscountCalculator
    {
        public DiscountCalculator()
        {
        }
        public double CalculateDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
            {
                return amount * 0.1;
            }
            else if (customerType == "Premium")
            {
                return amount * 0.2;
            }
            else if (customerType == "Student")
            {
                return amount * 0.15;
            }

            // More customer types  

            else
            {
                return 0;
            }

        }

        //<------------------------------------------->

        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        

        public double CalculateDiscount(double amount)
        {
            return _discountStrategy.CalculateDiscount(amount);
        }

    }

}
