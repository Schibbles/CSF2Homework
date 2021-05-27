using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {

        //fields
        private string _customerID;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInfo;
        //properties
        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }
        //ctors
        public Customer()
        {

        }
        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInfo)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }
        //methods
        public override string ToString()
        {
            return string.Format("Customer ID: {0}\n" +
                "First Name: {1}\n" +
                "Last Name: {2}\n" +
                "Contact Info:\n{3}",
                CustomerID, FirstName, LastName, ContactInfo);
        }
    }
}
