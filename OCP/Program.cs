using OCP;
using OCP.DiscountOCP;

DiscountCalculator discountCalculator = new DiscountCalculator();

//string customerType = "Regular";
//double amount = 1000;
//var discount = discountCalculator.CalculateDiscount(customerType, amount);

//Console.WriteLine($"Discount for {customerType} at {amount} = {discount}");


string customerType = "Student";
switch(customerType)
{
    case "Regular": 
        discountCalculator = new DiscountCalculator(new RegularCustomer());
        break;
    case "Student":
        discountCalculator = new DiscountCalculator(new StudentCustomer());
        break;
    case "Premium":
        discountCalculator = new DiscountCalculator(new PremiumCustomer());
        break;
    default:
        Console.WriteLine("Error!!!");
        break;
}

 
double amount = 1000;

double discount;
try
{
    discount = discountCalculator.CalculateDiscount(amount);
    Console.WriteLine($"Discount for {customerType} at {amount} = {discount}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
    //throw new Exception(NullReferenceException);
}
