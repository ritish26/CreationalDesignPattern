using FDP.Interface;

namespace FDP.PaymentMethods;

public class PaypalPayment : IPaymentProcessorInterface
{
    public void PaymentProcess(decimal amount)
    {
        Console.WriteLine($"Payment process through PayPal: {amount}");
    }
}