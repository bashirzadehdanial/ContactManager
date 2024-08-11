using System;
using System.Collections.Generic;

namespace ContactManager
{
    public class ContactManager
    {
        private List<Contact> contacts;

        public ContactManager()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        public void ListContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                Console.WriteLine("\nContact List:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }

        public void SearchContact(string name)
        {
            var foundContacts = contacts.FindAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (foundContacts.Count == 0)
            {
                Console.WriteLine("No contacts found with that name.");
            }
            else
            {
                Console.WriteLine("Search Results:");
                foreach (var contact in foundContacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }
    }
}
