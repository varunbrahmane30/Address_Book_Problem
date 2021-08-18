﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookProblemUpdated
{
    class AddressBook
    {
		public List<Contacts> userList;	
		public AddressBook()
		{
			this.userList = new List<Contacts>();
		}
		public void AddContact(String firstName, String lastName, String address, String city, String state, String zip, String contact, String email)
		{
			bool duplicate = equals(firstName);
			if (duplicate)
			{
				Console.WriteLine($"Duplicate Contact not allowed '{0}' is already in address book", firstName);
			}
			else
			{
				Contacts user = new Contacts(firstName, lastName, address, city, state, zip, contact, email);
				userList.Add(user);
			}
		}
		public bool equals(string first_name)
		{
			if (userList.Any(e => e.firstName == first_name))
				return true;
			else
				return false;
		}

		public void Display()
		{
			if (userList.Count() > 0)
			{
				Console.WriteLine("----------------------------------------------------------------------");
				Console.WriteLine("FirstName  LastName  Address,  City,  State,  Zip,   Contact,   Email");
				Console.WriteLine("----------------------------------------------------------------------");
				foreach (Contacts cont in userList)
				{
					cont.print();
				}
				Console.WriteLine("-----------------------------End_of_book------------------------------");
			}
			else
			{
				Console.WriteLine("Address_Book is Empty...!!!!!");
			}
		}
		public void EditContact(string fname)
		{
			int size = userList.Count;
			int check = 0;
			foreach (Contacts user in userList)
			{
				check++;
				if (user.firstName.Equals(fname))
				{
					userList.Remove(user);
					Console.Write("Enter FirstName: ");
					string firstName = Console.ReadLine();
					Console.Write("Enter LastName: ");
					string lastName = Console.ReadLine();
					Console.Write("Enter Address : ");
					string address = Console.ReadLine();
					Console.Write("Enter City : ");
					string city = Console.ReadLine();
					Console.Write("Enter State : ");
					string state = Console.ReadLine();
					Console.Write("Enter zip Code : ");
					string zipCode = Console.ReadLine();
					Console.Write("Enter Phone No: ");
					string PhoneNumber = Console.ReadLine();
					Console.Write("Enter Email: ");
					string eMail = Console.ReadLine();
					AddContact(firstName, lastName, address, city, state, zipCode, PhoneNumber, eMail);
					break;
				}
				else if (size == check)
				{
					Console.WriteLine(fname + " not found in addressbook...");
					break;
				}
			}
		}

		public void DeletContact(string Fname)
		{
			int size = userList.Count;
			int check = 0;
			foreach (Contacts user in userList)
			{
				check++;
				if (user.firstName.Equals(Fname))
				{
					userList.Remove(user);
					Console.WriteLine("Contact Deleted Successfully...");

					break;
				}
				else if (size == check)
				{
					Console.WriteLine(Fname + " not found in addressbook...");
					break;
				}
			}
		}
		public void SerchContact(string place)
		{
			List<string> person = new List<string>();
			bool exits = isPlaceExist(place);
			if (exits)
			{
				Console.WriteLine("Contacts From Place: " + place);
				foreach (Contacts user in userList.FindAll(x => x.address.Equals(place)).ToList())
				{
					string name = user.firstName + " " + user.lastName;
					person.Add(name);
				}
				foreach (Contacts user in userList.FindAll(x => x.state.Equals(place)).ToList())
				{
					string name = user.firstName + " " + user.lastName;
					person.Add(name);
				}
				foreach (string val in person)
				{
					Console.WriteLine(val);
				}
			}
			else
			{
				Console.WriteLine($"Contect not Found From {0}", place);
			}
		}
		public bool isPlaceExist(string place)
		{
			if (this.userList.Any(e => e.city == place) || this.userList.Any(e => e.state == place))
				return true;
			else
				return false;
		}
		public void CountContact(string countPlace)
		{
			int count = 0;
			bool exits = isPlaceExist(countPlace);
			if (exits)
			{
				Console.WriteLine("Contacts From Place: " + countPlace);
				foreach (Contacts user in userList.FindAll(x => x.address.Equals(countPlace)).ToList())
				{
					count++;
				}
				foreach (Contacts user in userList.FindAll(x => x.state.Equals(countPlace)).ToList())
				{
					count++;
				}
				Console.WriteLine($"Total Contacts From {countPlace} : {count}");
			}
			else
			{
				Console.WriteLine($"Contect not Found From {0}", countPlace);
			}
		}
		public void SortAlphabetically(int choice1)
		{
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("FirstName   LastName   Address,  City,  State,  Zip,   Contact,  Email");
			Console.WriteLine("----------------------------------------------------------------------");
			switch (choice1)
			{
				case 1:
					userList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.firstName, y.firstName)));
					foreach (Contacts contact in userList)
					{
						contact.print();
					}
					break;

				case 2:
					userList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.city, y.city)));
					foreach (Contacts contact in userList)
					{
						contact.print();
					}
					break;

				case 3:
					userList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.state, y.state)));
					foreach (Contacts contact in userList)
					{
						contact.print();
					}
					break;
				case 4:
					userList.Sort(new Comparison<Contacts>((x, y) => string.Compare(x.zipCode, y.zipCode)));
					foreach (Contacts contact in userList)
					{
						contact.print();
					}
					break;
			}
		}
		public void writeInTxtFile()
		{
			WriteFile.WriteUsingStreamWriter(userList);
			Console.WriteLine("Contacts Stored in TextFile.");
		}
		public void readFromTxtFile()
		{
			WriteFile.readFile();
		}
		public void writeInCsvFile()
		{
			WriteFile.csvFileWriter(userList);
		}

		public void readFromCsvFile()
		{
			WriteFile.readFromCSVFile();
		}
	}
}
