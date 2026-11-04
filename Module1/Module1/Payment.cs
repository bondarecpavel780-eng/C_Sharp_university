using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public interface Payment
    {
        void ProcessPayment(double amount);
    }
    public class CardPayment : Payment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата карткою: {amount} грн");
        }
    }

    public class CashPayment : Payment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Оплата готівкою: {amount} грн");
        }
    }
}
