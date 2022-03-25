using System;
using System.Collections.Generic;

namespace AddresBook
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string emailId;
    }

    public class PersonDetail
    {
        List<Person> listgetDetail;
        public PersonDetail()
        {
            listgetDetail = new List<Person>(); //list
        }
        public void PersonAddress()   //get persons detail
        {
            Person person = new Person();
            Console.WriteLine("Enter first name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter city");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter zipCode");
            person.zipCode = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter emaiId");
            person.emailId = Console.ReadLine();

            listgetDetail.Add(person);
        }
        public void DispalyAddressBook()   //show persons detail
        {
            foreach (Person person in listgetDetail)
            {
                Console.WriteLine("first Name: " + person.firstName);
                Console.WriteLine("last Name: " + person.lastName);
                Console.WriteLine("Address: " + person.address);
                Console.WriteLine("City: " + person.city);
                Console.WriteLine("State: " + person.state);
                Console.WriteLine("Zip code: " + person.zipCode);
                Console.WriteLine("PhoneNumber: " + person.phoneNumber);
                Console.WriteLine("EmailId: " + person.emailId);
                Console.WriteLine("----------------------------\n");
            }
        }

        public void EditAddressBook(string firstname)  //modify person detail
        {

            foreach (Person person in listgetDetail)
            {
                if (firstname == person.firstName)
                {
                    Console.WriteLine("Enter first name");
                    person.firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    person.lastName = Console.ReadLine();
                    Console.WriteLine("Enter address");
                    person.address = Console.ReadLine();
                    Console.WriteLine("Enter city");
                    person.city = Console.ReadLine();
                    Console.WriteLine("Enter state");
                    person.state = Console.ReadLine();
                    Console.WriteLine("Enter zipCode");
                    person.zipCode = Console.ReadLine();
                    Console.WriteLine("Enter phone number");
                    person.phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter emaiId");
                    person.emailId = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Contact not found!!");
                }
            }
        }
        public void DeleteAddressBook(string firstname)   //delete persons detail
        {
            int count = 0;
            int flag = 0; ;
            foreach (Person person in listgetDetail)
            {
                if (firstname == person.firstName)
                {
                    flag = 1;
                    break;
                }

                count++;  //count records in number
            }
            if (flag == 1)
            {
                listgetDetail.Remove(listgetDetail[count]);
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Contact not found!!");
            }
        }
    }

    public class AddressBookCollection   //Add multiple address book
    {
        public Dictionary<string, PersonDetail> addressBookDictionary;
        public AddressBookCollection()
        {
            addressBookDictionary = new Dictionary<string, PersonDetail>();
        }
        public void AddressBookNames()
            {
            foreach(var item in addressBookDictionary)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
    
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book management system!");

            AddressBookCollection addressBookCollection = new AddressBookCollection();            
            PersonDetail persongetDetail = new PersonDetail();
            persongetDetail.PersonAddress();
            int choice;
            do
            {
                Console.WriteLine("Enter your choice");
                
                Console.WriteLine("1) Add a new contact to address book");
                Console.WriteLine("2) Display address book");
                Console.WriteLine("3) Edit existing contact using persons first_name ");
                Console.WriteLine("4) Delete existing contact using persons first_name ");
                Console.WriteLine("5) Add new Address book");
                Console.WriteLine("6) List of address book");
                Console.WriteLine("7) Exit");
               
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {                   
                    case 1:
                        persongetDetail.PersonAddress();                        
                        break;
                    case 2:
                        Console.WriteLine("Address book is ");
                        persongetDetail.DispalyAddressBook();
                        break;
                    case 3:
                        Console.WriteLine("Enter first name");
                        string firstname = Console.ReadLine();
                        persongetDetail.EditAddressBook(firstname);
                        break;
                    case 4:
                        Console.WriteLine("Enter first name");
                        firstname = Console.ReadLine();
                        persongetDetail.DeleteAddressBook(firstname);
                        break;
                    case 5:
                        Console.WriteLine("Enter New Address Book Name");
                        string addresBookName = Console.ReadLine();
                        addressBookCollection.addressBookDictionary.Add(addresBookName, new PersonDetail());
                        Console.WriteLine("Address Book {0} selected.", addresBookName);
                        break;
                    case 6:
                        Console.WriteLine("List of all Address Books");
                        foreach (var item in addressBookCollection.addressBookDictionary)
                        {
                            Console.WriteLine(item.Key);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }while (choice != 7);

        }
    }
}