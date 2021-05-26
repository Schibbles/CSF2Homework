using System;
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
            Console.WriteLine("First Name: {0}\n" +
                "Last Name: {1}\n" +
                "ID: {2}\n" +
                "GPA: {3}",
                s1.FirstName, s1.LastName, s1.ID, s1.GPA);

            Vehicle v1 = new Vehicle();
            v1.Make = "Chevrolet";
            v1.Model = "Equinox";
            v1.Year = 2020;
            v1.Weight = 3275F;
            Console.WriteLine(v1);
            Console.WriteLine("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2}\n" +
                "Weight: {3}lbs.",
                v1.Make, v1.Model, v1.Year, v1.Weight);

            Login l1 = new Login();
            l1.UserName = "Schibbles";
            l1.Password = "Riku2021";
            Console.WriteLine(l1);
            Console.WriteLine("Username: {0}\n" +
                "Password: {1}",
                l1.UserName, l1.Password);

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "1731 Cedargate Way";
            c1.City = "Imperial";
            c1.State = "MO";
            c1.Zip = "63052";
            c1.Phone = "314-462-8408";
            c1.Email = "dschejbal@outlook.com";
            Console.WriteLine(c1);
            Console.WriteLine("Street Address: {0}\n" +
                "City: {1}\n" +
                "State: {2}\n" +
                "Zip Code: {3}\n" +
                "Phone: {4}\n" +
                "Email: {5}",
                c1.StreetAddress,c1.City,c1.State,c1.Zip,c1.Phone,c1.Email);
        }
    }
}
