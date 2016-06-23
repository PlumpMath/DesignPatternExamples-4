using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FacadePattern
{
    class DownPayment
    {
   
        
            public bool HasDownPayment(Customer customer, int amountToBorrow)
            {
                Console.WriteLine("Checking to see if {0} has enough savings for down payment", customer.Name);

            if (customer.Balance > amountToBorrow / 5)
            {
                Console.WriteLine("{0} has enough for the down payment", customer.Name);
                return true;
            }
            else
            {
                Console.WriteLine("{0} does not have enough for the down payment", customer.Name);
                return false;
            }
   
            }
        }
    }

