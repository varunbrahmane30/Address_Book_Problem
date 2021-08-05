using System;

namespace AddressBookProblemUpdated
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddressBook.addAddressBook();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.EditContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            AddressBook.ContactsDisplay();
            AddressBook.ContactsDisplay();
            AddressBook.ContactsDisplay();
        }
    }
}
