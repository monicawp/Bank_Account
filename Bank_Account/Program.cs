using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {

            // loop variable 
            string anotherTransaction = "";
           
                // Instantiating Client object, Checking object, and Savings object
                Client client1 = new Bank_Account.Client("Monica", " W", " Perez", 1545);
                Saving savings = new Saving(1000, 0, 0, 100);
                Checking checking = new Bank_Account.Checking(500, 0, 0);
            

            //With every loop, the amount does not reset, if you withdraw $100 from checking,
            // which the balance is $500 and then after the loop withdraw another 100, the balance will say
            // 300, because it will take into account every transaction you made. same for savings
            do
            {
                // Intro Menu 
                Console.WriteLine("Enter the number for which task you would like to preform:");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");

                int menuOptions = int.Parse(Console.ReadLine());

                if (menuOptions == 1)
                {
                    client1.ClientInfo();
                }
               
                else if (menuOptions == 2)
                {
                    Console.WriteLine("  A. Savings");
                    Console.WriteLine("  B. Checking");
                    char savOrCheck = char.Parse(Console.ReadLine().ToUpper());
                    if (savOrCheck == 'A')
                    {
                        savings.Balance();
                    }
                    else if (savOrCheck == 'B')
                    {
                        checking.Balance();
                    }
                }
                else if (menuOptions == 3)
                {
                    Console.WriteLine("  A. Savings");
                    Console.WriteLine("  B. Checking");
                    char savOrCheck = char.Parse(Console.ReadLine().ToUpper());
                    if (savOrCheck == 'A')
                    {
                        Console.WriteLine("Enter deposit amount:");
                        savings.DepositFunds = double.Parse(Console.ReadLine());
                        double newBalance = savings.Deposit();
                        Console.WriteLine("Your New Balance is: $" + newBalance + " dollars");
                    }
                    else if (savOrCheck == 'B')
                    {
                        Console.WriteLine("Enter deposit amount:");
                        checking.DepositFunds = double.Parse(Console.ReadLine());
                        double newBalance = checking.Deposit();
                        Console.WriteLine("Your New Balance is: $" + newBalance + " dollars");
                    }
                }
                else if (menuOptions == 4)
                {
                    Console.WriteLine("  A. Savings");
                    Console.WriteLine("  B. Checking");
                    char savOrCheck = char.Parse(Console.ReadLine().ToUpper());
                    if (savOrCheck == 'A')
                    {
                        Console.WriteLine("Enter Withdraw Amount: ");
                        savings.WithdrawAmt = double.Parse(Console.ReadLine());
                        double newBalance = 0;
                        if (newBalance <= 100)
                        {
                            Console.WriteLine("You Must Have a Minimum of 100 Dollars in Your Savings Account.");
                            Console.WriteLine("Please Re-enter a Valid Amount to withdraw.");
                            savings.WithdrawAmt = int.Parse(Console.ReadLine());

                            newBalance = savings.Withdraw();
                            Console.WriteLine("Your Cash is Dispensing");
                            Console.WriteLine("Your New Balance is: $" + newBalance + " dollars");
                        }
                        else if (newBalance > 100 )
                        {
                            newBalance = savings.Withdraw();
                            Console.WriteLine("Your Cash is Dispensing");
                            Console.WriteLine("Your New Balance is: $" + newBalance + " dollars");
                        }
                    }
                    else if (savOrCheck == 'B')
                    {
                        Console.WriteLine("Enter Withdraw Amount: ");
                        checking.WithdrawAmt = double.Parse(Console.ReadLine());
                        double newBalance = 0;
                        
                        if (newBalance < checking.WithdrawAmt)
                        {
                           Console.WriteLine("The Amount You Entered Exceeds the Funds Available in Your Account");
                            Console.WriteLine("Please Enter a Valid Withdraw Amount");
                            checking.WithdrawAmt = int.Parse(Console.ReadLine());
                            newBalance = checking.Withdraw();
                            Console.WriteLine("Your Cash is Dispensing");
                            Console.WriteLine("Your New Balance is: $" + newBalance + " dollars");
                        }
                        else if (newBalance > checking.WithdrawAmt) 
                        {
                            newBalance = checking.Withdraw(); 
                            Console.WriteLine("Your Cash is Dispensing");
                            Console.WriteLine("Your New Balance is: $" + newBalance + " dollars");
                        }
                    }

                }
                if (menuOptions == 5)
                {
                    Console.WriteLine("Thank you for banking with us!");
                }
                else
                {
                    Console.WriteLine("Would you like to make another transaction? Yes/No");
                    anotherTransaction = Console.ReadLine();
                }
              
            }
           
            
            while ( anotherTransaction == "Yes" || anotherTransaction == "yes" );
            if (anotherTransaction == "No" || anotherTransaction == "no")
            {
                Console.WriteLine("Thank you for banking with us!"); 
            }
       







        }
         }
   }
