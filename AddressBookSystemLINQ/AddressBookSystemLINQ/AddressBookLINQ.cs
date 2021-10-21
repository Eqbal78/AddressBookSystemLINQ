using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        /// <summary>
        /// Insert Contacts in Address book data table
        /// </summary>
        public void InsertContacts()
        {
            //add rows in dataTable
            dataTable.Rows.Add("Tony", "Stark", "Stark Tower", "Manhattan", "NewYork", "100001", "8987224534", "ironman@gmail.com");
            dataTable.Rows.Add("Steve", "Rogers", "Times Square", "Brooklyn", "Texas", "1122", "9876778434", "capAmerica@yahoo.com");
            dataTable.Rows.Add("Bruce", "Banner", "Vandalia", "Dayton", "Florida", "45441", "1403425612", "hulkBuster@gmail.com");
            dataTable.Rows.Add("Peter", "Parker", "Queens", "NewYork", "NewYork", "10023", "4013224355", "spiderman@gmail.com");
            dataTable.Rows.Add("Stephen", "Strange", "Bleecker", "Manhattan", "NewYork", "10431", "6300964579", "drStrange@yahoo.com");
            dataTable.Rows.Add("Thor", "Odinson", "RoyalPalace", "Asgard", "Florida", "22544", "7849876734", "thor@rediffmail.com");
            dataTable.Rows.Add("Natasha", "Romanoff", "Broadway", "NewYork", "NewYork", "10028", "4566735277", "blackwidow@gmail.com");
            dataTable.Rows.Add("Pepper", "Potts", "Stark Tower", "Manhattan", "NewYork", "100001", "8987224534", "pepper@gmail.com");
            dataTable.Rows.Add("Edwin", "Jarvis", "Stark Tower", "Manhattan", "Texas", "100112", "6767986886", "jarvis@gmail.com");
            dataTable.Rows.Add("Howard", "Stark", "Richford", "Manhattan", "NewYork", "100001", "9876543256", "stark@yahoo.com");

            DisplayDataTable();
        }

        /// <summary>
        /// Display Address Book data table
        /// </summary>
        public void DisplayDataTable()
        {
            foreach (DataColumn col in dataTable.Columns)
            {
                Console.Write(col.ToString().PadRight(14));
            }
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine();
                foreach (DataColumn col in dataTable.Columns)
                {
                    Console.Write(row[col].ToString().PadRight(14));
                }
            }
        }

        /// <summary>
        /// Editing exiting Contact Details using persons's name
        /// </summary>
        public void EditContact()
        {
            string name = "Tony";
            //Find the first name in dataTable
            var rowToUpdate = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if (rowToUpdate != null)
            {
                rowToUpdate.SetField("PhoneNumber", "8300987876");
                rowToUpdate.SetField("Zip", "534260");
                Console.WriteLine("\n\nPhoneNumber and ZipCode of {0} updated successfully!\n", name);
                DisplayDataTable();
            }
            else
            {
                Console.WriteLine("\nThere is no such record in the Address Book!");
            }
        }

        /// <summary>
        ///  Delete Contact using persons's name
        /// </summary>
        /// <param name="name"></param>
        public void DeleteContact(string name)
        {
            //Find the first name in dataTable
            var rowToDelete = dataTable.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals(name)).FirstOrDefault();
            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                Console.WriteLine("\n\nContact with name '{0}' deleted successfully!\n", name);
                DisplayDataTable();
            }
            
        }

    }
}