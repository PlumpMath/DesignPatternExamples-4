using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.FacadePattern
{
    class Customer
    {

        private string _name;
        private float _balance;
        private int _creditScore;
        public string Name
        {
            get { return _name; }
        }   
        public float Balance
        {
            get { return _balance; }
        }
        public int CreditScore
        {
            get { return _creditScore; }
        }
        public Customer(string name)
            {
                this._name = name;
                this._balance = 50000;
                this._creditScore = 600;
            }


        }
    }

