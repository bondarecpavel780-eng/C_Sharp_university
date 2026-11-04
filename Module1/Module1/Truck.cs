using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    internal class Truck : Transport
    {
        public Truck()
        {
            Name = "Вантажівка";
            MaxWeight = 10000;
        }

        public override double CalculateCost(Order order)
        {
            return 200 + 15 * order.Distance + 0.5 * order.Weight;
        }
    }
}
