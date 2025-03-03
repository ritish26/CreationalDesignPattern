using FDP.Interface;

namespace FDP.PaymentMethods;

public class UpiPayment : IPaymentProcessorInterface
{
    public void PaymentProcess(decimal amount)
    {
        Console.WriteLine($"Payment process through Upi: {amount}");
    }
}