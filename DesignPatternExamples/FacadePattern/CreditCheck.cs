using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FacadePattern
{
    class CreditCheck
    {

        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Checking if {0}'s credit score meets requirements", customer.Name);
            if (customer.CreditScore > 700)
            {
                Console.WriteLine("{0}'s Credit Score meets requirements", customer.Name);
                return true;
            }
            else
            {
                Console.WriteLine("{0}'s Credit Score does not meet requirements", customer.Name);
                return false;
            }

        }
    }
}
 

