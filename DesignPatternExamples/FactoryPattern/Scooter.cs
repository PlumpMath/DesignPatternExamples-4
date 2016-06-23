using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    class Scooter : Vehicle
    {
        public override void move()
        {
            Console.WriteLine("Putt, putt, goes the Scooter");
        }
    }
}
