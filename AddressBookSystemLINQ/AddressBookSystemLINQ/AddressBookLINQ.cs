using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookSystemLINQ
{
    class AddressBookLINQ
    {
        // Create Data table to store address book details
        public DataTable dataTable = new DataTable();

        /// <summary>
        /// Create DataTable 
        /// </summary>
        public void CreateAddressBook()
        {
            //create columns in dataTable
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));
            Console.WriteLine("Address Book Data Table Created Successfully!!");
        }
    }
}
