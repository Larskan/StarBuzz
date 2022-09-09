using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class Beverage : IOrder
    {
        public string BeverageName { get; set; } = "This is your chosen Beverage";
        public bool Milk { get; set; }
        public bool Sugar { get; set; }
        public bool Whip { get; set; }
        public double TotalCost = 0;

        public Beverage(bool whip, bool milk, bool sugar)
        {
            Whip = whip;
            Milk = milk;
            Sugar = sugar;
        }
       
      

        public int HouseBlend { get; set; }
        public int Condiments { get; set; }

        public override string ToString()
        {
            return "Beverage [BeverageName="+BeverageName + ", HouseBlend="+HouseBlend + ", Condiments="+Condiments+"]";
        }

       

        public double CondimentCost()
        {
            if(Whip == true)
            {
                TotalCost += 0.1;
            }
            if(Sugar == true){
                TotalCost += 0.2;
            }
            if(Milk == true)
            {
                TotalCost += 0.5;
            }
            return TotalCost;

        }

        public double BeverageCost()
        {
            if(BeverageName == "DarkRoast")
            {
                TotalCost += 1.1;
            }
            if (BeverageName == "HouseBlend")
            {
                TotalCost += 1.2;
            }
            if (BeverageName == "Decaf")
            {
                TotalCost += 1.4;
            }
            return TotalCost;
        }

        public IOrder CostTemp()
        {
            BeverageName = "";
            HouseBlend = 0;
            Condiments = 0;
            return this;

        }

    }
}
