using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Bike : Transport
    {
        public Bike()
        {
            Name = "Bike";
            MaxWeight = 15;
        }

        public override double CalculateCost(Order order)
        {
            return 20 + 5 * order.Distance;
        }

        public override bool CanTake(Order order)
        {
            if (order.Distance > 10)
            {
                return false;
            }
            return base.CanTake(order);
        }

    }
}
