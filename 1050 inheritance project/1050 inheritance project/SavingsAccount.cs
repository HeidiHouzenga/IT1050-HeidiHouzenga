using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050_inheritance_project
{

    //Derived Class inherit : Account
    class SavingsAccount : Account
    {
        //decimal interest var
        private decimal _interestRate;
        
        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;

        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value > 0)
                    _interestRate = value;
                else
                    throw new Exception("Interest rate is should be greater than 0");              
            }

         }

        //method to calculate interest
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}
