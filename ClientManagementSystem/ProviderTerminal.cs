using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSystem
{
    class ProviderTerminal
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Provider Terminal!");
            Console.WriteLine("To continue, please choose one of the options below:");
            Console.WriteLine("1) Exit (It's going to happen no matter what you enter)");
            Console.WriteLine();
            Console.ReadLine();
            return;
        }
    }
}
