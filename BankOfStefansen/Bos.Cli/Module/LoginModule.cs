using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bos.Cli.Module
{
    public class LoginModule
    {
        public void Login()
        {
            bool loginSucces = false;

            do
            {
                Console.Clear();

                Console.WriteLine("#==== Bank Of Stefansen ====#");
                Console.WriteLine("    Administration Login.");
                Console.WriteLine();

                Console.WriteLine("Please Type Username:");
                string username = Console.ReadLine().ToLower();

                Console.WriteLine("Please Type Password:");
                string password = Console.ReadLine();

                if (username == "gud" && password == "gud")
                {
                    loginSucces = true;
                }
            }
            while (!loginSucces);
        }
    }
}
