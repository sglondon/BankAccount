using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Client 
    {
        //fields

        string acctNumChecking = "";
        string acctNumSavings = "";
        string acctOwner = "";
        
       

        //Properties

        public string AcctNumChecking
        {
            get { return this.acctNumChecking; }
        }
       

        public string AcctNumSavings
        {
            get { return this.acctNumSavings; }
        }

        public string AcctOwner
        {
            get { return this.acctOwner; }
        }

        //Constructors

        public Client()
        {
            //default constructor
        }

        public Client(string acctNumChecking, string acctNumSavings, string acctOwner )
        {
         
        }

        //Method

        DisplayClien()
        {
            Console.WriteLine()
        }

        //  public override bool ValidAcct(bool valid);
    }
    }




