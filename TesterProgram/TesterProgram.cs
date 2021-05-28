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


            Console.WriteLine("\n\n----Book Info----\n\n");
            Book bk1 = new Book();
            bk1.Title = "The Fire Within";
            bk1.Author = "Chris d'Lacy";
            bk1.NumberOfPages = 340;
            Console.WriteLine(bk1);

            Book bk2 = new Book("Icefire", "Chris d'Lacy", 421);
            Console.WriteLine(bk2);

            List<Book> books = new List<Book> { bk1, bk2 };//Created a List of books to use in Library

            Console.WriteLine("\n\n----Library Info----\n\n");
            Library lib1 = new Library();
            lib1.LibraryName = "Schibble's Books";
            lib1.Inventory = books;
            lib1.StreetAddress = "123 Whichever Drive";
            lib1.City = "Arnold";
            lib1.State = "MO";
            lib1.Zip = "63010";
            Console.WriteLine(lib1);

            Library lib2 = new Library(books, "World's Biggest Library",  "123 Rainbow Road", "Pevely", "MO", "98752");
            Console.WriteLine(lib2);

            Console.WriteLine("\n\n----Song Info----\n\n");

            Song song1 = new Song();
            song1.Artist = "Tom MacDonald";
            song1.Title = "I Hate Hip-Hop";
            song1.Length = 245;
            Console.WriteLine(song1);

            Song song2 = new Song("Tom MacDonald", "I Don't Drink", 252);
            Console.WriteLine(song2);

            Song[] songs = new Song[2];//created an array to use below with Artist
            songs[0] = song1;
            songs[1] = song2;

            Console.WriteLine("\n\n----Artist Info----\n\n");

            Artist a1 = new Artist();
            a1.Songs = songs;
            a1.AlbumTitle = "Flowers for the Dead";
            a1.Genre = "Rap";
            Console.WriteLine(a1);

            Artist a2 = new Artist(songs, "Gravestones", "Rap");
            Console.WriteLine(a2);

            Console.WriteLine("\n\n----MotorHome Info----\n\n");

            MotorHome m1 = new MotorHome("Thor", "Challenger 37FH", 2022, 24000F, 1);
            Console.WriteLine(m1);

            MotorHome m2 = new MotorHome();
            m2.Make = "This is";
            m2.Model = "a motorhome";
            m2.Year = 2018;
            m2.Weight = 20000F;
            m2.NumberOfBeds = 17;
            Console.WriteLine(m2);

            Console.WriteLine("\n\n----Truck Info----\n\n");

            Truck t1 = new Truck("Chevrolet", "Colorado", 2012, 3400F, 1285F);
            Console.WriteLine(t1);

            Truck t2 = new Truck();
            t2.Make = "Ford";
            t2.Model = "F-350";
            t2.Year = 2018;
            t2.Weight = 5876F;
            t2.LoadCapacity = 3761F;
            Console.WriteLine(t2);
        }
    }
}
