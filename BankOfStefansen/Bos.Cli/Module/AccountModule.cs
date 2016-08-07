using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bos.Cli.Module
{
    public class AccountModule
    {
        public void Start()
        {
            PrintMenu();
            HandleInput();
        }

        public void HandleInput()
        {
            Console.ReadLine();
        }

        public void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("#==== Bank Of Stefansen ====#");
            Console.WriteLine("          Accounts.");
            Console.WriteLine();

            Console.WriteLine("Menu Options");
            Console.WriteLine(" - List [All]");
            Console.WriteLine(" - New");
            Console.WriteLine(" - Back");
        }
    }
}
