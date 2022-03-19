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
            listgetDetail = new List<Person>();
        }
        public void PersonAddress()
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
        public void DispalyAddressBook()
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
            }
        }

        public void EditAddressBook(string firstname)
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
    }
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book management system!");
            PersonDetail persongetDetail = new PersonDetail();
            persongetDetail.PersonAddress();
            int choice;
            do
            {
                Console.WriteLine("Enter your choice");
                
                Console.WriteLine("1) Add a new contact to address book");
                Console.WriteLine("2) Display address book");
                Console.WriteLine("3) Edit existing contact using person's first name ");
                Console.WriteLine("4) Exit");
               
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
                        Console.WriteLine("Exit");
                        break;                    
                }
            }while (choice != 4) ;

        }
    }
}

