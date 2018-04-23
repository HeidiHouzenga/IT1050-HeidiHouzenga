using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050_inheritance_project
{

    //Base Class
    class Account
    {
        //private variable
        private decimal _balance;

        //constructor
        public Account(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                {
                    throw new Exception("Cannot be a negative balance");
                }
            }
        }

        //2 public method for credit
        public virtual void Credit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new Exception("Credit amount greater than 0");
        }

        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                Console.Write("Debit amount exceeded account balance.");
                OK = false;
            }

            
            return OK;
        }

    }
}
