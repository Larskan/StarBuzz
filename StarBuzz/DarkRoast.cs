using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(bool whip, bool milk, bool sugar) : base(whip, milk, sugar)
        {
            whip = false;
            milk = false;
            sugar = false;
        }
    }
}
