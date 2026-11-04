namespace Module1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Delivery service = new Delivery();

            Bike bike = new Bike();
            Car car = new Car();
            Truck truck = new Truck();

            service.AddTransport(bike);
            service.AddTransport(car);
            service.AddTransport(truck);

            Order order1 = new Order { Number = 1, Description = "Документи", Weight = 1, Distance = 5 };
            Order order2 = new Order { Number = 2, Description = "Телевізор", Weight = 20, Distance = 15 };
            Order order3 = new Order { Number = 3, Description = "Цегла", Weight = 1500, Distance = 30 };

            service.ShowCosts(order1);
            service.ShowCosts(order2);
            service.ShowCosts(order3);

            Console.WriteLine();

            service.AssignOrder(order1, bike);
            service.AssignOrder(order2, car);
            service.AssignOrder(order3, truck);

            service.ShowStatus();

            Payment card = new CardPayment();
            Payment cash = new CashPayment();

            Console.WriteLine();

            service.DeliverOrder(order1, bike, card);
            service.DeliverOrder(order2, car, cash);

            service.ShowStatus();
        }
    }
}
