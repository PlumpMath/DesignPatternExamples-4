using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.DependancyInjection
{
    class AdvancedSupplies : ISupplies
    {
        public void cleanHouse()
        {
            Console.WriteLine("Beep Boop Goes the Cleaning Robot");
        }
    }
}
