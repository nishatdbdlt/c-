using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public string Roll { get; set; }
    public string Section { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Roll: {Roll}, Section: {Section}");
    }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>();
        Console.Write("How many students: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Roll: ");
            string roll = Console.ReadLine() ?? "";

            Console.Write("Section: ");
            string section = Console.ReadLine() ?? "";

            students.Add(new Student { Name = name, Roll = roll, Section = section });
        }

        Console.WriteLine("\nStudent Details:");
        foreach (var s in students)
        {
            s.Display();
        }
    }
}
    

