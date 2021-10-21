using System;

namespace AddressBookSystemLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using LINQ!");
            AddressBookLINQ linq = new AddressBookLINQ();
            linq.CreateAddressBook();
            linq.InsertContacts();
            //linq.EditContact();
            linq.DeleteContact("Edwin");
            
        }
    }
}
