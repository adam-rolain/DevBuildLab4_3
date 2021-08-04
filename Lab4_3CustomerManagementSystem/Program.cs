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
            DisplayCustomers(customers);

            Console.WriteLine("Testing out search function");
            Customer found = SearchForCustomer(customers, "CVS");
            Console.WriteLine(found);
            Customer notFound = SearchForCustomer(customers, "Meijer");
            Console.WriteLine(notFound);
        }

        static void DisplayCustomers(List<Customer> customers)
        {
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        static Customer SearchForCustomer(List<Customer> customers, string customerName)
        {
            foreach(Customer customer in customers)
            {
                if (customer.GetCompany() == customerName)
                {
                    return customer;
                }
            }
            Console.WriteLine($"There was no customer with the name of {customerName}");
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
