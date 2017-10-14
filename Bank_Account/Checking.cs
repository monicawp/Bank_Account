using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Account
    {

        //fields
        private double checkAccountBalance = 500.00;

        //propertiess

        public double CheckAccountBalance
        {
            get { return this.checkAccountBalance; }
        }

        //default constructor

        public Checking()
        {

        }
        // constructor
        
        public Checking(int checkAccountBalance, double depAmt, double withdrawAmt)
        {
            this.checkAccountBalance = checkAccountBalance;
            this.DepositFunds = depAmt;
            this.WithdrawAmt = withdrawAmt; 

        }

        // methods

        // inheriting from the virtual method in Account class 
        public override void Balance()
        {
            base.Balance(); Console.WriteLine("$" + checkAccountBalance); 
        }

        //Does math for adding the user imput amount to the hard coded checking account balance
        //checking account balance is 500
        public override double Deposit()
        {
            checkAccountBalance = DepositFunds + checkAccountBalance;

            return checkAccountBalance; 
            
        }

        public override double Withdraw()
        {
            checkAccountBalance = checkAccountBalance - WithdrawAmt;
            return checkAccountBalance; 
        }









    }
}
