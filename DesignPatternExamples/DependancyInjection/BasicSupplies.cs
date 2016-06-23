using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.DependancyInjection
{
    class BasicSupplies : ISupplies
    {
        public void cleanHouse()
        {
            Console.WriteLine("Swish Swoosh Goes the Mop and Bucket");
        }
    }
}
