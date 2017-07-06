using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can’t fly");
        }
    }
}
