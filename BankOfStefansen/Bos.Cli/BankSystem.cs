using Bos.Cli.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bos.Cli
{
    public class BankSystem
    {
        public void Start()
        {
            Login();

            PrintMenu();
            HandleInput();
        }

        public void Login()
        {
            // Log The User In Before Use
            LoginModule logingModule = new LoginModule();
            logingModule.Login();
            Console.Clear();

            Console.WriteLine("#==== Bank Of Stefansen ====#");
            Console.WriteLine("    Administration Panel.");
            Console.WriteLine();
            Console.WriteLine("Welcome To The Bank Of Stefansen.");
        }

        public void HandleInput()
        {
            string line = string.Empty;

            while ((line = Console.ReadLine().ToLower()) != "exit")
            {
                if (line == "account")
                {
                    Console.WriteLine("Niko");
                }
                else if (line == "settings")
                {
                    Console.WriteLine("There is no settings!! HAHAHAHA");
                }
                else if (line == "logout")
                {
                    Login();
                }
                else
                {
                    Console.WriteLine("The command does not exist.");
                    PrintMenu();
                }
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine(" - Account");
            Console.WriteLine(" - Settings");
            Console.WriteLine(" - LogOut");
            Console.WriteLine(" - Exit");
        }
    }
}
