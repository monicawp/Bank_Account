using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account
    {
        //Fields 

        private int accountNumber = 1545;
        private double depositFunds;
        private int actBalance;
        private double withdrawAmt;
        private string accountType; 



        // properties
       public double WithdrawAmt
        {
            get { return this.withdrawAmt; }
            set { this.withdrawAmt = value;  }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public double DepositFunds
        {
            get { return this.depositFunds; }
            set { this.depositFunds = value; }
        }

        public int ActBalance {get;} 
           

        //method

            //virtual method being inherited by checking and savings
        public virtual void Balance()
        {
            Console.WriteLine("Your Account Balance is: "); 
        }

        public abstract double Deposit();

        public abstract double Withdraw(); 

        
       
    }
}
