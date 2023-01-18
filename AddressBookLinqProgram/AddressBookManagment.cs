using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinqProgram
{
    public class AddressBookManagment
    {
        DataTable datatable = new DataTable();
        public void InsertContactInToTable()
        {
            Console.WriteLine("inserting contacts into datatable");
            datatable.Columns.Add("FirstName", typeof(string));
            datatable.Columns.Add("LastName", typeof(string));
            datatable.Columns.Add("Address", typeof(string));
            datatable.Columns.Add("City", typeof(string));
            datatable.Columns.Add("State", typeof(string));
            datatable.Columns.Add("Zip", typeof(int));
            datatable.Columns.Add("PhoneNumber", typeof(long));
            datatable.Columns.Add("Email", typeof(string));
            datatable.Rows.Add("harshu", "v", "abc", "some", "somewhere", 601627, 9722673323, "harshu@gmail.com");
            datatable.Rows.Add("riya", "s", "abc", "some", "kl", 601627, 7136435612, "riya@gmail.com");
            datatable.Rows.Add("teena", "k", "abc", "hnk", "ks", 601627, 9188277162, "teena@gmail.com");
            datatable.Rows.Add("milky", "g", "abc", "hyd", "ts", 601627, 8127516253, "milky@gmail.com");
            datatable.Rows.Add("tom", "f", "abc", "some", "tl", 601627, 7182161267, "tom@gmail.com");
        }
        public void DisplayContacts()
        {
            Console.WriteLine("displaying contacts in datatable");
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("FirstName" + row["FirstName"]);
                Console.WriteLine("LastName" + row["LastName"]);
                Console.WriteLine("Address" + row["Address"]);
                Console.WriteLine("City" + row["City"]);
                Console.WriteLine("State" + row["State"]);
                Console.WriteLine("Zip" + row["Zip"]);
                Console.WriteLine("PhoneNumber" + row["PhoneNumber"]);
                Console.WriteLine("Email" + row["Email"]);
            }
        }
        public void EditExistingContact(string firstName)
        {
            DataRow contact = datatable.Select("FirstName = " + firstName).FirstOrDefault();
            Console.WriteLine("edited successfully");
        }
        public void DeleteContact(string tom)
        {
            DataRow contact = datatable.Select("FirstName = " + tom).FirstOrDefault();
            datatable.Rows.Remove(contact);
            Console.WriteLine("Record Successfully Deleted");
        }
        public void RetrieveByCity(string city)
        {
            var retrieveData = from records in datatable.AsEnumerable() where records.Field<string>("City") == city select records;
            Console.WriteLine("retrieve contact details by using city");
            foreach (DataRow row in retrieveData)
            {
                Console.WriteLine("FirstName" + row["FirstName"]);
                Console.WriteLine("LastName" + row["LastName"]);
                Console.WriteLine("Address" + row["Address"]);
                Console.WriteLine("City" + row["City"]);
                Console.WriteLine("State" + row["State"]);
                Console.WriteLine("Zip" + row["Zip"]);
                Console.WriteLine("PhoneNumber" + row["PhoneNumber"]);
                Console.WriteLine("Email" + row["Email"]);
            }
        }
        public void RetrieveByState(string state)
        {
            var retrieveData = from records in datatable.AsEnumerable() where records.Field<string>("State") == state select records;
            Console.WriteLine("retrieve contact details by State");
            foreach (DataRow row in retrieveData)
            {
                Console.WriteLine("FirstName" + row["FirstName"]);
                Console.WriteLine("LastName" + row["LastName"]);
                Console.WriteLine("Address" + row["Address"]);
                Console.WriteLine("City" + row["City"]);
                Console.WriteLine("State" + row["State"]);
                Console.WriteLine("Zip" + row["Zip"]);
                Console.WriteLine("PhoneNumber" + row["PhoneNumber"]);
                Console.WriteLine("Email" + row["Email"]);
            }
        }
        public void sortContactAlphabeticallyForGivenCity(string City)
        {
            Console.WriteLine("sorting by contact for given city");
            var retrievedData = from records in datatable.AsEnumerable() where records.Field<string>("City") == City orderby records.Field<string>("FirstName") select records;
            foreach (var row in retrievedData)
            {
                Console.WriteLine("FirstName" + row["FirstName"]);
                Console.WriteLine("LastName" + row["LastName"]);
                Console.WriteLine("Address" + row["Address"]);
                Console.WriteLine("City" + row["City"]);
                Console.WriteLine("State" + row["State"]);
                Console.WriteLine("Zip" + row["Zip"]);
                Console.WriteLine("PhoneNumber" + row["PhoneNumber"]);
                Console.WriteLine("Email" + row["Email"]);
            }
        }
    }
}