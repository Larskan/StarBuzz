using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzProject
{

    //Open means that it can get add-ons easily, without changing the Beverage Class
    //If we want to add.. Tea for an example, we just create a Tea : Beverage class with a description and a cost
    //Same if we want to add a new condiment like.. mint, we just make Mint : CondimentDecorator, then adds it to description and cost
    //Open essentially means code that can be improved upon without touching the main part of it
    //Condiments and types of coffee are OPEN, simply because they will most likely change in the future

    public abstract class Beverage
    {
        /*
         * Lars's rambling corner:
         * I have no idea how to launch examples of the code, as can be seen below, I have tried going around the fact
         * that you can't instance an abstract, but clearly I am doing SOMETHING wrong, but I don't know what.
         * I tried figuring out the Launch class and then use it in the Main class, but kept getting errors.
         * In theory.. once the launching part is figured, it should work perfectly..
         * I fear I am overthinking it, the solution is probably stupidly obvious, yet right now it isn't
         */
        static void Main(string[] args)
        {
            //Launch();
            Console.WriteLine("Woo");

        }
        private static void Launch(Beverage b)
        {
            //b._Description = DarkRoast;

        }


        protected string _Description = "Unknown Beverage";

        //Get a description of the beverage
        public virtual string GetDescription()
        {
            return _Description;
        }
        //calculate cost of beverage
        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage { }

    #region HouseBlend
    //HouseBlend coffee implements Beverage
    public class HouseBlend : Beverage
    {
        //Constructor
        public HouseBlend()
        {
            _Description = "House Blend"; 
        }

        //Cost of House Blend
        public override double Cost()
        {
            return 1_2;
        }
    }
    #endregion

    #region DarkRoast
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _Description = "Dark Roast";
        }
        public override double Cost()
        {
            return 1_1;
        }
    }
    #endregion

    #region Decaf
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _Description = "Decaf";
           
        }
        public override double Cost()
        {
            return 1_4;
        }
    }
    #endregion

    #region Condiment Sugar
    public class Sugar : CondimentDecorator
    {
        Beverage beverage;
        public Sugar(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Sugar";
        }
        public override double Cost()
        {
            return 0_2 + beverage.Cost();
        }
    }
    #endregion

    #region Condiment Milk
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
        public override double Cost()
        {
            return 0_5 + beverage.Cost();
        }
    }
    #endregion

    #region Condiment Whip
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
        public override double Cost()
        {
            return 0_1 + beverage.Cost();
        }
    }
    #endregion

}
