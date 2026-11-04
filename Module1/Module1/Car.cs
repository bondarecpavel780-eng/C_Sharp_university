using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Car : Transport
    {
        public Car()
        {
            Name = "Car";
            MaxWeight = 700;
        }

        public override double CalculateCost(Order order)
        {
            return 50 + 8 * order.Distance + 1 * order.Weight;
        }
    }
}
