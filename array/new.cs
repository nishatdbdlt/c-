using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactBook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Search Contact");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        string phone = Console.ReadLine();
                        contacts[name] = phone;
                        break;
                    case "2":
                        Console.Write("Enter name to search: ");
                        string search = Console.ReadLine();
                        if (contacts.ContainsKey(search))
                            Console.WriteLine($"{search} - {contacts[search]}");
                        else
                            Console.WriteLine("Not found");
                        break;
                    case "3":
                        foreach (var c in contacts.OrderBy(x => x.Key))
                            Console.WriteLine($"{c.Key} - {c.Value}");
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
