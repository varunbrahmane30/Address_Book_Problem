using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookProblemUpdated
{
    class WriteFile
    {
        public static string path = @"D:\Brigelabz\PracticProblem\AddressBookProblemUpdated\AddressBookProblemUpdated\AddessBookData.txt";
        public static string pathCsv = @"D:\Brigelabz\PracticProblem\AddressBookProblemUpdated\AddressBookProblemUpdated\AddressBookData.csv";
        public static void WriteUsingStreamWriter(List<Contacts> data)
        {

            if (File.Exists(path))
            {
                File.WriteAllText(path, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("FirstName\tLastName\t Address\t City\t State\t ZipCode\t PhoneNumber\t Email");
                    foreach (Contacts contact in data)
                    {
                        streamWriter.WriteLine(contact.firstName + "\t" + contact.lastName + "\t" + contact.address + "\t" + contact.city + "\t" + contact.state + "\t" + contact.zipCode + "\t" + contact.phoneNumber + "\t" + contact.eMail);
                    }
                    streamWriter.Close();
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void readFile()
        {
            if (File.Exists(path))
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void csvFileWriter(List<Contacts> data)
        {

            if (File.Exists(pathCsv))
            {
                File.WriteAllText(pathCsv, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(pathCsv))
                {
                    streamWriter.WriteLine("FirstName,LastName,Address,City,State,Zip,Contact,Email");
                    foreach (Contacts contacts in data)
                    {
                        streamWriter.WriteLine(contacts.firstName + "," + contacts.lastName + "," + contacts.address + "," + contacts.city + "," + contacts.state + "," + contacts.zipCode + "," + contacts.phoneNumber + "," + contacts.eMail);
                    }
                    streamWriter.Close();
                    Console.WriteLine("Contacts Stored in Csv_File.");
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
        public static void readFromCSVFile()
        {
            if (File.Exists(pathCsv))
            {
                using (StreamReader streamReader = File.OpenText(pathCsv))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        string[] csv = data.Split(",");
                        foreach (string dataCsv in csv)
                        {
                            Console.Write(dataCsv + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
    }
}
