using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields
        //props
        public List<Book> Inventory { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        //ctors
        public Library()
        {

        }
        public Library(List<Book> inventory, string libraryName, string streetAddress, string city,string state, string zip)
        {
            Inventory = inventory;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        //methods
        public override string ToString()
        {
            string booksOwned = "";
            foreach (Book book in Inventory)
            {
                booksOwned += book;
            }
            return string.Format("Library Name: {0}\n" +
                "We have: {1}\n" +
                "Street Address: {2}\n" +
                "City: {3}\n" +
                "State: {4}\n" +
                "Zip: {5}",
                LibraryName, booksOwned, StreetAddress, City, State, Zip);
        }
    }
}
