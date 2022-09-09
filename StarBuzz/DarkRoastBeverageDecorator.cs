using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class DarkRoastBeverageDecorator : BeverageDecorator
    {
        public DarkRoastBeverageDecorator(IOrder order) : base(order)
        {

        }
        public override IOrder CostTemp()
        {
            order.CostTemp();
            AddOrder(order);
            return order;
        }
        public void AddOrder(IOrder order)
        {
            if(order is Beverage)
            {
                Beverage beverage = (Beverage)order;
                //Beverage.HouseBlend = "";
                Console.WriteLine("DarkRoastBeverageDecorator added DarkRoast to the blend : " + order);
            }
        }
    }
}
