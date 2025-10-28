using System;

namespace SortingSearchingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("6 Sorting and Searching Menu");
                Console.WriteLine("1. Display numbers");
                Console.WriteLine("2. Bubble Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Binary Search");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Display(numbers);
                        break;

                    case "2":
                        BubbleSort(numbers);
                        Console.WriteLine("Array sorted using Bubble Sort:");
                        Display(numbers);
                        break;

                    case "3":
                        SelectionSort(numbers);
                        Console.WriteLine("Array sorted using Selection Sort:");
                        Display(numbers);
                        break;

                    case "4":
                        Console.Write("Enter number to search: ");
                        int target = int.Parse(Console.ReadLine());
                        Array.Sort(numbers);
                        int index = BinarySearch(numbers, target);
                        if (index == -1)
                            Console.WriteLine("Number not found!");
                        else
                            Console.WriteLine($"Found at position {index + 1}");
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void Display(int[] arr)
        {
            Console.WriteLine("Numbers: " + string.Join(", ", arr));
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return -1;
        }
    }
}
