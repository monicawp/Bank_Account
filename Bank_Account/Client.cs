using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client 
    {
        //Fields 
        //Hard coded client information
        private string firstName = "Monica";
        private string middleInitial = "W.";
        private string lastName = "Perez";

        
        // Properties MUST HAVE 3
        //1
        public string FirstName
        {
            get { return this.firstName; }
        }
        //2
        public string MiddleInitial
        {
          get { return this.middleInitial; }
        }
        //3
        public string LastName
        {
            get { return this.lastName; }
        }
         
        // default contructor 

        public Client()
        {

        }

        // Constructors MUST HAVE 1

        public Client(string firstName, string middleInitial, string lastName)
        {
            this.firstName = firstName;
            this.middleInitial = middleInitial;
            this.lastName = lastName;
        }

        // method MUST HAVE 1

        public void ClientInfo()
        {
            Console.WriteLine(firstName + middleInitial + lastName);
          
        }









    }
}
