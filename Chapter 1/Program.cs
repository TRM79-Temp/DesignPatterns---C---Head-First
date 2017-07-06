using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns, Chapter 1:");

            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
