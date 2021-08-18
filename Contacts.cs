using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProblemUpdated
{
    class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string eMail;

        public Contacts(String firstName, String lastName, String address, String city, String state, String zipCode, String phoneNumber, String eMail)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
        }


        public void print()
        {
            Console.WriteLine(firstName + " \t  " + lastName + " \t  " + address + " \t  " + city + " \t  " + state + " \t " + zipCode + "\t " + phoneNumber + " \t  " + eMail);
        }
    }

}
