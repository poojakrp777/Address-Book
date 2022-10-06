using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookClass add = new AddressBookClass();
            add.AddContact();
        }
    }
}
