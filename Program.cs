using System;

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactManager manager = new ContactManager();

            while (true)
            {
                Console.WriteLine("\nContact Manager");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. List Contacts");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        string phoneNumber = Console.ReadLine();

                        Contact newContact = new Contact(name, phoneNumber);
                        manager.AddContact(newContact);
                        break;

                    case "2":
                        manager.ListContacts();
                        break;

                    case "3":
                        Console.Write("Enter name to search: ");
                        string searchName = Console.ReadLine();
                        manager.SearchContact(searchName);
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
