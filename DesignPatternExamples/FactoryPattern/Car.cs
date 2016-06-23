using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    class Car : Vehicle
    {
        public override void move()
        {
            Console.WriteLine("Vroom, Vroom, goes the car");
        }
    }
}
