using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());
            string[] products = new string[n];
            double[] prices = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Product {i + 1} name: ");
                products[i] = Console.ReadLine();
                Console.Write($"Product {i + 1} price: ");
                prices[i] = double.Parse(Console.ReadLine());
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display Products");
                Console.WriteLine("2. Sort by Price");
                Console.WriteLine("3. Search Product by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        for (int i = 0; i < n; i++)
                            Console.WriteLine($"{products[i]} - ${prices[i]}");
                        break;
                    case "2":
                        BubbleSort(products, prices);
                        Console.WriteLine("Products sorted by price:");
                        for (int i = 0; i < n; i++)
                            Console.WriteLine($"{products[i]} - ${prices[i]}");
                        break;
                    case "3":
                        Console.Write("Enter product name to search: ");
                        string target = Console.ReadLine();
                        int index = Array.IndexOf(products, target);
                        if (index == -1) Console.WriteLine("Not found");
                        else Console.WriteLine($"Found: {products[index]} - ${prices[index]}");
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

        static void BubbleSort(string[] products, double[] prices)
        {
            int n = prices.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (prices[j] > prices[j + 1])
                    {
                        double tempPrice = prices[j];
                        prices[j] = prices[j + 1];
                        prices[j + 1] = tempPrice;

                        string tempProduct = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = tempProduct;
                    }
                }
            }
        }
    }
}
