using System.Data;

namespace AddressBookLinqProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book system using linq");
            AddressBookManagment addressBookManagment = new AddressBookManagment();

            addressBookManagment.InsertContactInToTable();
            addressBookManagment.DisplayContacts();
            addressBookManagment.EditExistingContact("FirstName");
            addressBookManagment.DeleteContact("tom");
            addressBookManagment.RetrieveByCity("some");
            addressBookManagment.RetrieveByState("somewhere");
            addressBookManagment.sortContactAlphabeticallyForGivenCity("hyd");
        }
    }
}