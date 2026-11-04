using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Delivery
    {
        private Transport[] transports = new Transport[10];
        private int transportCount = 0;

        private Order[] activeOrders = new Order[10];
        private int activeCount = 0;

        private Order[] history = new Order[10];
        private int historyCount = 0;

        public void AddTransport(Transport transport)
        {
            transports[transportCount] = transport;
            transportCount++;
        }

        public void ShowCosts(Order order)
        {
            Console.WriteLine($"\nВартість доставки замовлення N: {order.Number}:");
            for (int i = 0; i < transportCount; i++)
            {
                if (transports[i].CanTake(order))
                {
                    Console.WriteLine($"{transports[i].Name}: {transports[i].CalculateCost(order)} грн");
                }
            }
        }

        public void AssignOrder(Order order, Transport transport)
        {
            if (!transport.IsBusy && transport.CanTake(order))
            {
                transport.IsBusy = true;
                activeOrders[activeCount] = order;
                activeCount++;
                Console.WriteLine($"Замовлення N: {order.Number} везе {transport.Name}");
            }
            else
            {
                Console.WriteLine($"Неможливо призначити N: {order.Number} на {transport.Name}");
            }
        }

        public void DeliverOrder(Order order, Transport transport, Payment paymentMethod)
        {
            if (transport.IsBusy)
            {
                double cost = transport.CalculateCost(order);
                paymentMethod.ProcessPayment(cost);
                transport.IsBusy = false;

                history[historyCount] = order;
                historyCount++;

                for (int i = 0; i < activeCount; i++)
                {
                    if (activeOrders[i] == order)
                    {
                        activeOrders[i] = null;
                    }
                }
                Console.WriteLine($"Замовлення N: {order.Number} доставлено.");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine("\n=== Активні замовлення ===");
            for (int i = 0; i < activeCount; i++)
            {
                if (activeOrders[i] != null)
                {
                    Console.WriteLine($"N: {activeOrders[i].Number} - {activeOrders[i].Description}");
                }
            }

            Console.WriteLine("\n=== Історія доставок ===");
            for (int i = 0; i < historyCount; i++)
            {
                Console.WriteLine($"N: {history[i].Number} - {history[i].Description}");
            }
        }
    }
}
