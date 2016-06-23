using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    abstract class VehicleFactory
    {
        public abstract Vehicle getVehicle(string typeOfVehicle);
    }
}
