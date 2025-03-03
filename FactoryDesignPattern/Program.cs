// See https://aka.ms/new-console-template for more information

using FDP.Interface;
using FDP.PaymentMethods;

namespace FDP;

/// Problem Statement :
/// You are designing a payment processing system that supports multiple payment methods,
/// such as Credit Card, PayPal, and UPI. The system should be able to create the appropriate payment processor
/// dynamically based on the user’s selected payment method.

#region MainMethod
public class Program
{
    public static void Main()
    {
        IPaymentProcessorInterface paymentProcessorPaypalInterface = new PaypalPayment();
        paymentProcessorPaypalInterface.PaymentProcess(10);
        
        IPaymentProcessorInterface paymentProcessorUpiInterface = new UpiPayment();
        paymentProcessorUpiInterface.PaymentProcess(10);
        
        IPaymentProcessorInterface paymentProcessorCreditcardInterface = new CreditCardPayment();
        paymentProcessorCreditcardInterface.PaymentProcess(10);
        
    }
}
#endregion

