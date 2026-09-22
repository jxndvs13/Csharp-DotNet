using System;

namespace PaymentSystem
{
    public abstract class Payment
    {
        public abstract void ProcessPayment(double amount);
        public void DisplayReceipt(){ Console.WriteLine("Thank you for your payment."); }
    }
    internal class CreditCardPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}.");
        }
    }
    internal class PayPalPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreditCardPayment cc = new CreditCardPayment();
            cc.ProcessPayment(100.0);
            cc.DisplayReceipt();

            PayPalPayment pp = new PayPalPayment();
            pp.ProcessPayment(100.0);
            pp.DisplayReceipt();
        }
    }
}