using System;

namespace AddressBookProblemUpdated
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddressBook.AddContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.EditContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.DeleteContact();
            AddressBook.ContactsDisplay();

        }
    }
}
