using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public abstract class Account
    {
        //fields
        private double acctBal;
        private double deposit;
        private double wDrawal;

        //properties

        public double AcctBal
        {
            get { return this.acctBal; }
            set { this.acctBal = value; }
        }



        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double WDrawal
        {
            get { return this.wDrawal; }
            set { this.wDrawal = value; }
        }


        //abstract methods

        public abstract double GetBalance();
        public abstract double GetDeposit();
        public abstract double GetWdrawal();
         


        
    }
}
