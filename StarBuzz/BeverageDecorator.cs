using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public abstract class BeverageDecorator : IOrder
    {
        protected IOrder order;
        public BeverageDecorator(IOrder order)
        {
            this.order = order;
        }
        public virtual IOrder CostTemp()
        {
            return order.CostTemp();
        }
    }
}
