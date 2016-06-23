using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FacadePattern
{
    class LoanHistory
    {
        private string _loanHistory = "Good";
   
            public bool HasGoodLoanHistory(Customer customer)
            {
                Console.WriteLine("Checking Loan History for {0}", customer.Name);
            if (_loanHistory == "Good")
            {
                Console.WriteLine("The loan history for {0} is good", customer.Name);
                return true;
            }
            else
            {
                Console.WriteLine("The loan history for {0} is bad", customer.Name);
                return false;
            }
            }
        }
    }

