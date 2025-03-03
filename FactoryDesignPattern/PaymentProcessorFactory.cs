using FDP.Interface;
using FDP.PaymentMethods;

namespace FDP;

#region PaymentProcessorFactory
public  class PaymentProcessorFactory
{
    public static IPaymentProcessorInterface CreatePaymentProcessor(string paymentProcessor)
    {
        switch (paymentProcessor)
        {
            case "CreditCard":
                return new CreditCardPayment();
            case "PayPal":
                return new PaypalPayment();
            case "upi":
                return new UpiPayment();
        }
        
        throw new Exception("Unknown payment processor");
    }
}
#endregion
