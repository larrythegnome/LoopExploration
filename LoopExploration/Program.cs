using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Fig" };

            for(int i = 5; i >= 1; i--) 
            {
                Console.WriteLine($"Counting down: {i}");
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("Blast off!");

            Console.WriteLine("\nList of Fruits");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();

            string password;

            Console.WriteLine("\nEnter the password: ");
            password = Console.ReadLine();

            while(password != "secret123") 
            {
                Console.WriteLine("Wrong password. Try again: ");
                password = Console.ReadLine();
            }
            Console.WriteLine("Password accepted!");

            int choice;

            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. Display Fruits");
                Console.WriteLine("2. Start Countdown");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1/2/3): ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (string fruit in fruits)
                        {
                            Console.WriteLine(fruit);
                        }
                        break;
                    case 2:
                        for (int i = 5; i >= 1; i--)
                        {
                            Console.WriteLine($"Counting down: {i}");
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.WriteLine("Blast off!");
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }while (choice != 3);
        }
    }
}
