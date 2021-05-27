﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n----Student Info----\n\n");

            Student s1 = new Student();
            s1.FirstName = "Patrick";
            s1.LastName = "Stephen";
            s1.ID = "846795";
            s1.GPA = 3.2F;
            Console.WriteLine(s1);
            Student s2 = new Student("Keith", "Harvey", "147288", 3.7F);
            Console.WriteLine(s2);

            Console.WriteLine("\n\n----Vehicle Info----\n\n");
            Vehicle v1 = new Vehicle();
            v1.Make = "Chevrolet";
            v1.Model = "Equinox";
            v1.Year = 2020;
            v1.Weight = 3275F;
            Console.WriteLine(v1);
            Vehicle v2 = new Vehicle("Chevrolet", "Cavalier", 2003, 2600);
            Console.WriteLine(v2);

            Console.WriteLine("\n\n----Login Info----\n\n");
            Login l1 = new Login();
            l1.UserName = "Schibbles";
            l1.Password = "Riku2021";
            Console.WriteLine(l1);
            Login l2 = new Login("Bwebbz", "Nora2020");
            Console.WriteLine(l2);

            Console.WriteLine("\n\n----Contact Info----\n\n");
            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1731 Cedargate Way";
            c1.City = "Imperial";
            c1.State = "MO";
            c1.Zip = "63052";
            c1.Phone = "314-462-8408";
            c1.Email = "dschejbal@outlook.com";
            Console.WriteLine(c1);
            ContactInfo c2 = new ContactInfo("42 Wallaby Way", "Sydney", "Arizona", "45789", "314-686-0636", "sprinter1@yahoo.com");
            Console.WriteLine(c2);

            Console.WriteLine("\n\n----Customer Info----\n\n");
            Customer cust1 = new Customer();
            cust1.CustomerID = "654321";
            cust1.FirstName = "Brianna";
            cust1.LastName = "Webb";
            cust1.ContactInfo = c1;
            Console.WriteLine(cust1);

            Customer cust2 = new Customer("987654", "Micheal", "Pierce", c2);
            Console.WriteLine(cust2);
            

            Console.WriteLine("\n\n----Credit Card Account Info----\n\n");
            CreditCardAccount cred1 = new CreditCardAccount();
            cred1.AccountNumber = 5134679;
            cred1.Customer = cust1;
            cred1.Balance = 6543;
            cred1.IsPastDue = true;
            cred1.AnnualInterestRate = 4.2m;
            Console.WriteLine(cred1);

            CreditCardAccount cred2 = new CreditCardAccount(789451, cust2, 4300, false, 2.8m);
            Console.WriteLine(cred2);
        }
    }
}
