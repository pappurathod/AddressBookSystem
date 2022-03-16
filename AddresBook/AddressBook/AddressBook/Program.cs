
//UC1-AddressBookSystem
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

        public void AdressBook(string FirstName, string LastName, string Address, string City, string State, string Zipcode, string PhoneNumber, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.zipcode = Zipcode;
            this.PhoneNumber = PhoneNumber;
            this.EmailId = EmailId;

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");

            AddresBook addbook = new AddresBook();

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

            // Dictionary<String, string> myaddbook = new Dictionary<String, string>();
        }
    }
}