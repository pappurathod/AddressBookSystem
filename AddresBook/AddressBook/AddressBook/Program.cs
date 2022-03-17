//UC2

namespace AddressBook
{
    class AddresBook
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string zipcode;
        public string PhoneNumber;
        public string EmailId;
    }
    public class PersonDetail
    {
        AddresBook addbook = new AddresBook();
        public void SetPersonDetail()
        {
            Console.WriteLine("Enter First name");
            addbook.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name");
            addbook.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            addbook.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            addbook.City = Console.ReadLine();
            Console.WriteLine("enter State");
            addbook.State = Console.ReadLine();
            Console.WriteLine("Enter your Zipcode");
            addbook.zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            addbook.PhoneNumber = Console.ReadLine();
            Console.WriteLine("enter your email id");
            addbook.EmailId = Console.ReadLine();

        }

        public void GetPersonDetail()
        {
            Dictionary<String, string> myaddbook = new Dictionary<String, string>();
            myaddbook.Add("FirstName", addbook.FirstName);
            myaddbook.Add("LastName", addbook.LastName);
            myaddbook.Add("Address", addbook.Address);
            myaddbook.Add("City", addbook.City);
            myaddbook.Add("State", addbook.State);
            myaddbook.Add("zipcode", addbook.zipcode);
            myaddbook.Add("PhoneNumber", addbook.PhoneNumber);
            myaddbook.Add("EmailID", addbook.EmailId);
            
            foreach (KeyValuePair<String, string> item in myaddbook)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }        
    }

    class Program
    {
        public static void Main(string[] args)
        {
            PersonDetail perdeatil = new PersonDetail();
            perdeatil.SetPersonDetail();
            perdeatil.GetPersonDetail();
            Console.WriteLine("enter 'y' for Add New Contact");
            string ch = Console.ReadLine();
            if (ch == "y")
            {
                perdeatil.SetPersonDetail();
            }
        }
    }
}
