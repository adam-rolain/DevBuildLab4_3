using System;

namespace Lab4_3CustomerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Customer class
            Customer c1 = new Customer("Walgreens", "Joe Rodriguez", "JoeRodriguez@Walgreens.com", "248-092-9034");
            Console.WriteLine(c1);
            Customer c2 = new Customer("CVS", "Ron Ramirez", "RonRamirez@CVS.com", "248-881-6752");
            Console.WriteLine(c2);

        }
    }

    class Customer
    {
        // PRIVATE MEMBERS
        private string pCompany;
        private string pContactName;
        private string pContactEmail;
        private string pPhone;

        // CONSTRUCTOR
        public Customer(string company, string contactName, string contactEmail, string phone)
        {
            SetCompany(company);
            SetContactName(contactName);
            SetContactEmail(contactEmail);
            SetPhone(phone);
        }

        // GETTERS AND SETTERS
        public string GetCompany()
        {
            return pCompany;
        }
        public void SetCompany(string company)
        {
            pCompany = company;
        }
        public string GetContactName()
        {
            return pContactName;
        }
        public void SetContactName(string contactName)
        {
            pContactName = contactName;
        }
        public string GetContactEmail()
        {
            return pContactEmail;
        }
        public void SetContactEmail(string contactEmail)
        {
            pContactEmail = contactEmail;
        }
        public string GetPhone()
        {
            return pPhone;
        }
        public void SetPhone(string phone)
        {
            pPhone = phone;
        }

        // TOSTRING METHOD
        public override string ToString()
        {
            return $"-----------COMPANY INFO-----------\nCompany: {pCompany}\nContact Name: {pContactName}\nContact Email: {pContactEmail}\nPhone Number: {pPhone}";
        }
    }
}
