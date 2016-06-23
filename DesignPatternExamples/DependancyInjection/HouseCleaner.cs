using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.DependancyInjection
{
    class HouseCleaner
    {

       ISupplies _supplies;
        public HouseCleaner(ISupplies supplies)
        {
            this._supplies = supplies;
        }
        public void cleanHouse()
        {
            _supplies.cleanHouse();
        }
    }
}
