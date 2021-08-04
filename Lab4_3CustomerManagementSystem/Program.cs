using System;
using System.Collections.Generic;

namespace Lab4_3CustomerManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Customer class
            Customer c1 = new Customer("Walgreens", "Joe Rodriguez", "JoeRodriguez@Walgreens.com", "248-092-9034");
            Customer c2 = new Customer("CVS", "Ron Ramirez", "RonRamirez@CVS.com", "248-881-6752");
            Customer c3 = new Customer("Rite Aid", "Jim Jones", "JimJones@RiteAid.com", "248-761-6904");

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            Console.WriteLine("-------CUSTOMER MANAGEMENT SYSTEM-------");
            Console.Write("Would you like to search for a company by [C]ompany Name or [P]hone? ");
            string input = Console.ReadLine();
            string search = "";
            Customer customer = null;

            switch (input)
            {
                case "C":
                    Console.Write("Please enter a name of a customer you would like to search for: ");
                    search = Console.ReadLine();
                    customer = SearchForCustomerByCompany(customers, search);
                    if (customer != null)
                    {
                        Console.WriteLine(customer);
                    }
                    break;
                case "P":
                    Console.Write("Please enter a phone number of a customer you would like to search for: ");
                    search = Console.ReadLine();
                    customer = SearchForCustomerByPhone(customers, search);
                    if (customer != null)
                    {
                        Console.WriteLine(customer);
                    }
                    break;
            }  
        }

        static void DisplayCustomers(List<Customer> customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        static Customer SearchForCustomerByCompany(List<Customer> customers, string companyName)
        {
            foreach(Customer customer in customers)
            {
                if (customer.GetCompany() == companyName)
                {
                    return customer;
                }
            }
            Console.WriteLine($"There was no customer with the name of {companyName}");
            return null;
        }

        static Customer SearchForCustomerByPhone(List<Customer> customers, string phone)
        {
            foreach (Customer customer in customers)
            {
                if (customer.GetPhone() == phone)
                {
                    return customer;
                }
            }
            Console.WriteLine($"There was no customer with the phone number of {phone}");
            return null;
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
