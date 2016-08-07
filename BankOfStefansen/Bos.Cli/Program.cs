using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bos.Cli
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Setting The Title Of The Console
            Console.Title = "Bank Of Stefansen";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();

            // Making Startup Sound
            // Better Than Windows Start Up Sound
            Console.Beep();
            Console.Beep();

            BankSystem system = new BankSystem();
            system.Start();
        }
    }
}
