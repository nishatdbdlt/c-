using System;
using System.Collections;
using System.IO.Compression;


class Car
{

    public string Brand;
    public string model;
    public string price;
    public void display()
    {
        Console.WriteLine(" car info");
        Console.WriteLine("brand;" + Brand);
        Console.WriteLine("Modle:" + model);
        Console.WriteLine("price:" + price);

    }
class Program
    {
        static void Main()
        {
            Car mycar = new Car();
            Console.Write("enter your Brand");

            mycar.Brand = Console.ReadLine();


            Console.Write("enter your model");
            mycar.model = Console.ReadLine();

            Console.Write("enter your price");
            mycar.price = Console.ReadLine();

            mycar.display();
            
        }
    }
}