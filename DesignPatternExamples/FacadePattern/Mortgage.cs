using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FacadePattern
{
    class Mortgage
    {

            private DownPayment _downPayment = new DownPayment();
            private LoanHistory _loanHistory = new LoanHistory();
            private CreditCheck _credit = new CreditCheck();

            public bool IsEligible(Customer customer, int amountOfLoan)
            {
                Console.WriteLine("{0} is applying for a loan of {1}", customer.Name, amountOfLoan);

                bool eligible = true;

                // Check creditworthyness of applicant
                if (!_downPayment.HasDownPayment(customer, amountOfLoan))
                {
                    eligible = false;
                }
                else if (!_loanHistory.HasGoodLoanHistory(customer))
                {
                    eligible = false;
                }
                else if (!_credit.HasGoodCredit(customer))
                {
                    eligible = false;
                }

                return eligible;
            }
        }
    }


