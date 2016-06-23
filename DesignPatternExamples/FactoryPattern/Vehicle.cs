using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    abstract class  Vehicle
    {
        public virtual void move()
        {
            //This could have been an Interface, but I wanted to show it as an abstract class
        }
        protected void consumeFuel()
        {
            Console.WriteLine("Here is where I would put a fuel consumption calcuation");
        }
        
    }
}
