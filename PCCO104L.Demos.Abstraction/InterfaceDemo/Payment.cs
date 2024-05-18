namespace PCCO104L.Demos.Abstraction.Interfaces
{
    //Abstraction Layer
    //Define an interface representing any payment method
    public interface IPaymentMethod
    {
        bool ProcessPayment(decimal amount);
    }

    //Concrete Implementations
    //Implement the interface for each payment method
    public class CreditCardPayment : IPaymentMethod
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
            // Logic to process credit card payment
            return true; // Let's assume the payment is successful for this example.
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
            // Logic to process PayPal payment
            return true;
        }
    }

    public class BitcoinPayment : IPaymentMethod
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of {amount:C}");
            // Logic to process Bitcoin payment
            return true;
        }
    }

    //Using the Abstraction
    //With the abstraction in place, the checkout process becomes simplified
    public class CheckoutSystem
    {
        public void Checkout(IPaymentMethod paymentMethod, decimal amount)
        {
            if (paymentMethod.ProcessPayment(amount))
            {
                Console.WriteLine("Payment successful!");
            }
            else
            {
                Console.WriteLine("Payment failed.");
            }
        }
    }
}
