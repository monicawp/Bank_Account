using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Saving : Account
    {

        //fields
        private double savAccountBalance = 1000;
        private double minBalance = 100;


        //properties

        public double AccountBalance
        {
            get { return this.savAccountBalance; }
        }
        
        public double MinBalance
        {
            get { return this.minBalance; }

        }
    
        //default constructor

        public Saving()
        {
            
        }

        // constructor 
        public Saving(double savAccountBalance, double depAmt, double withdrawAmt, double minBalance)
        {
            this.savAccountBalance = savAccountBalance;
            this.DepositFunds = depAmt;
            this.WithdrawAmt = withdrawAmt;
            this.minBalance = minBalance; 
        }

        //method

        public override void Balance()
        {
            Console.WriteLine("Your Savings Account Balance is: " + savAccountBalance + " dollars" );
        }

        public override double Deposit()
        {
            savAccountBalance = DepositFunds + savAccountBalance;


            return savAccountBalance;
        }

        public override double Withdraw()
        {
            savAccountBalance = savAccountBalance - WithdrawAmt;
            return savAccountBalance; 
        }








    }
}
