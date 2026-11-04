using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public abstract class Transport
    {
        public string Name;
        public double MaxWeight;
        public bool IsBusy;

        public abstract double CalculateCost(Order order);

        public virtual bool CanTake(Order order)
        {
            return order.Weight <= MaxWeight;
        }
    }
}
