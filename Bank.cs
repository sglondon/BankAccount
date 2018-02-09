using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Bank
    {

        //fields
        //invisible


        //properties
        //list of objects as a property
        //be aware of going forward**
        public List<Client> AllClients { get; set; }
        public List<Checking> CheckingAccounts { get; set; }
        public List{Savings> SavingAccounts {get; set;}

    //method whose return type is a list of strings
    public List<string> DisplayClientNames()
    {
        List<string> clientnName = new List<string>(); //new empty list
        foreach (Client client in AllClients)       //for each client object, add the name property to the new list
        {
            clientNames.Add(client.Name) //this just grabs name property, not whole object

        }
        return clientNames;  //return type is a string list of client names
    }


    }
}
