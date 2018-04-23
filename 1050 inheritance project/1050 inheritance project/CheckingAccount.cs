using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050_inheritance_project
{

    //Derived Class inherit : Account
    class CheckingAccount : Account
    {
        //decimal variable for fee
        private decimal _fee;

        //constructor balance and fee amount
        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;
        }

        public decimal Fee
        {
            get { return _fee; }
            set
            {
                if (value > 0)
                    _fee = value;
                else
                    throw new Exception("Fee cannot be less than 0");
            }
        }


        //methods credit and debit to subtract the fee
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance -= Fee;
                return true;
             }

            return false;
        }
    }
}
