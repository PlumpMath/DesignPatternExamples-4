using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    class Motorbike : Vehicle
    {
        public override void move()
        {
            Console.WriteLine("zoom zoom goes the motorbike");
        }
    }
}
