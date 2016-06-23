using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FactoryPattern
{
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override Vehicle getVehicle(string typeOfVehicle)
        {
            switch (typeOfVehicle.ToLower())
            {
                case "bike":
                    return new Bike();
                case "car":
                    return new Car();
                case "scooter":
                    return new Scooter();
                case "motorbike":
                    return new Motorbike();
                default:
                    throw new ApplicationException(string.Format("I don't know how to create a {0}, please enter a vaild choice", typeOfVehicle));
            }
        }

    }
}
