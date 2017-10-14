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

        // constructor MUST HAVE 1
        public Saving(double savAccountBalance, double depAmt, double withdrawAmt, double minBalance)
        {
            this.savAccountBalance = savAccountBalance;
            this.DepositFunds = depAmt;
            this.WithdrawAmt = withdrawAmt;
            this.minBalance = minBalance; 
        }

        //method
        

        // inheriting from the virtual method in Account class 
        //method to show account balance
        public override void Balance()
        {
            base.Balance(); Console.WriteLine("$" + savAccountBalance);
        }

        //Does math for adding the user imput amount to the hard coded savings account balance
        //savings account balance is 1000
        public override double Deposit()
        {
            savAccountBalance = DepositFunds + savAccountBalance;


            return savAccountBalance;
        }

        //Does math for subtracting the user imput amount from the hard coded savings account balance
        // savings acount balance 1000
        public override double Withdraw()
        {
            savAccountBalance = savAccountBalance - WithdrawAmt;
            return savAccountBalance; 
        }








    }
}
