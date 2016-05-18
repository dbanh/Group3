using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSystem
{ 
    static class Program
    {
        static void Main(string[] args)
        {
            // Initialize - read info from files into database
            Console.WriteLine("Initializing...");
            Database.Initialize();
            Console.WriteLine("Done!");
            Console.WriteLine();

            // Main menu
            Console.WriteLine("Welcome to the ChocAn Client Management System! ");
            Program.ListMainMenuOptions(); // 1- Manager Terminal, 2- Provider Terminal, 3- Exit

            bool exitProgram = false;
            while (!exitProgram)
            {
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        // Login to Manager Terminal
                        ManagerTerminal managerTerminal = new ManagerTerminal();
                        managerTerminal.Run(); // Manager Terminal main menu
                        Console.WriteLine("You have exited the Manager Terminal.");
                        ListMainMenuOptions();
                        break;
                    case "2":
                        // Login to Provider Terminal
                        ProviderTerminal providerTerminal = new ProviderTerminal();
                        providerTerminal.Run(); // Provider Terminal main menu
                        Console.WriteLine("You have exited the Provider Terminal.");
                        ListMainMenuOptions();
                        break;
                    case "3":
                        // Exit
                        exitProgram = true;
                        break;
                    default:
                        // Bad input
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }

            // Write database changes to file and exit
            Console.WriteLine("Exiting...");
            Database.WriteChangesToFile();
        }

        public static void ListMainMenuOptions()
        {
            Console.WriteLine("To continue, please choose one of the following options:");
            Console.WriteLine("1) Login to Manager Terminal");
            Console.WriteLine("2) Login to Provider Terminal");
            Console.WriteLine("3) Exit");
            Console.WriteLine();
        }

    }


}
