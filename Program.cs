using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int userChoice;

            Client ClientOne = new Client("1234", "5678", "Ivy");

            //Display Menu

         //   do
         //       Console.WriteLine("To view Client Information, type 1");
                  
                Console.WriteLine("To View Account Balance, type 2");
                Console.WriteLine("To Deposit Funds, type 3");
                Console.WriteLine("To Withdraw Funds, type 4");
                Console.WriteLine("To Exit, type 5");

            //      switch (userChoice)
            //      {
                 if (userChoice == 1)
            { 

            int info = int.Parse(Console.ReadLine());
                        Console.WriteLine(ClientOne);
                }
            }   


        }
    }
}
