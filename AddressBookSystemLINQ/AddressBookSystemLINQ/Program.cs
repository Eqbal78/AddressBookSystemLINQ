using System;
using System.Data;

namespace AddressBookSystemLINQ
{
    class Program
    {
        private static DataTable dataTable;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using LINQ!");
            AddressBookLINQ linq = new AddressBookLINQ();
            linq.CreateAddressBook();
            linq.InsertContacts();
            //linq.EditContact();
            //linq.DeleteContact("Edwin");

            //linq.RetrieveContactsByCity("Manhattan");
            //linq.RetrieveContactsByState("Texas");

            //linq.CountByCity();
            //linq.CountByState();

            linq.CountByStates();
        }
    }
}
