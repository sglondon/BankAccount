using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Client : Account
    {
        //fields
        //invisible

        //Properties

        public string AcctNum { get; set; }
        public string AcctType { get; set; }
        public double Balance { get; set; }

        //Constructors

        public Client()
        {
            //default constructor
        }

        public Client(string AcctNum, string AcctType, double Balance)
        {
        AcctNum = acctNum;
        AcctType = acctType;
        Balance = balance;

        }
        public override void AccountNum()
        {
            Console.WriteLine("account number");
        }
    }



}
