namespace FDP.Interface;

public interface IPaymentProcessorInterface
{
    public void PaymentProcess(decimal amount);
}