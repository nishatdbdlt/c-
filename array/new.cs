using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            // Input numbers
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n=== Sorting & Searching Menu ===");
                Console.WriteLine("1. Display Numbers");
                Console.WriteLine("2. Bubble Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Linear Search");
                Console.WriteLine("5. Binary Search");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Display(numbers);
                        break;

                    case "2":
                        BubbleSort(numbers);
                        Console.WriteLine("\nArray sorted using Bubble Sort!");
                        Display(numbers);
                        break;

                    case "3":
                        SelectionSort(numbers);
                        Console.WriteLine("\nArray sorted using Selection Sort!");
                        Display(numbers);
                        break;

                    case "4":
                        Console.Write("Enter number to search: ");
                        int target1 = int.Parse(Console.ReadLine());
                        int index1 = LinearSearch(numbers, target1);
                        if (index1 == -1)
                            Console.WriteLine("Number not found!");
                        else
                            Console.WriteLine($"Number found at position {index1 + 1}");
                        break;

                    case "5":
                        Console.Write("Enter number to search: ");
                        int target2 = int.Parse(Console.ReadLine());
                        Array.Sort(numbers); // Ensure sorted
                        int index2 = BinarySearch(numbers, target2);
                        if (index2 == -1)
                            Console.WriteLine("Number not found!");
                        else
                            Console.WriteLine($"Number found at position {index2 + 1}");
                        break;

                    case "6":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void Display(int[] arr)
        {
            Console.WriteLine("\nNumbers: " + string.Join(", ", arr));
        }

        // Bubble Sort
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

        // Selection Sort
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

        // Linear Search
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // Binary Search (must be sorted)
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }

