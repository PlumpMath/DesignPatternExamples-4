using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    class Bike  : Vehicle
    {
        public override void move()
        {
            Console.WriteLine("I am riding by bike, my legs sure are tired");
        }
    }
}
