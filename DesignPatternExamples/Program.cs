using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facade Pattern Example
            Console.WriteLine("******Facade Pattern Example******");
            FacadePattern.Customer customer = new FacadePattern.Customer("Andrew");
            FacadePattern.Mortgage mortgage = new FacadePattern.Mortgage();
            bool eligible = mortgage.IsEligible(customer, 180000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            Console.ReadKey();
            //Dependancy Injection Example
            //Console.WriteLine("******Dependancy Injection Example******");
            ////DependancyInjection.BasicSupplies supplies = new DependancyInjection.BasicSupplies();
            //DependancyInjection.AdvancedSupplies supplies = new DependancyInjection.AdvancedSupplies();
            //DependancyInjection.HouseCleaner cleaner = new DependancyInjection.HouseCleaner(supplies);
            //cleaner.cleanHouse();
            //Console.ReadKey();
            ////Factory Pattern Example
            //Console.WriteLine("******Factory Pattern Example******");
            //FactoryPattern.VehicleFactory factory = new FactoryPattern.ConcreteVehicleFactory();
            //FactoryPattern.Vehicle myRide = null;
            //try
            //{
            //    myRide = factory.getVehicle("car");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    //Log stuff here
            //    Console.ReadKey();
            //    //Here I would normally Call a function that would give the use another chance to give correct input
            //    //But instead because this is a simple example, I am going to instantiate something that works
            //    myRide = new FactoryPattern.Scooter();
            //}
            //myRide.move();
            //Console.ReadKey();
            ////Observer Pattern Example
            //Console.WriteLine("******Observer Pattern Example******");
            //ObserverPattern.devCodeCamp devcodecamp = new ObserverPattern.devCodeCamp("dCC", 50);
            //devcodecamp.Attach(new ObserverPattern.Investor("Andrew"));
            //devcodecamp.Attach(new ObserverPattern.Investor("Mike"));
            //devcodecamp.Price = 60;
            //devcodecamp.Price = 70;
            //devcodecamp.Price = 70;
            //devcodecamp.Price = 20;
            //Console.ReadKey();




        }
    }
}
