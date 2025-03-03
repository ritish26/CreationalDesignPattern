using FDP.Interface;

namespace FDP.PaymentMethods;

public class CreditCardPayment : IPaymentProcessorInterface
{
    public void PaymentProcess(decimal amount)
    {
        Console.WriteLine($"Payment process through CreditCard: {amount}");
    }
}