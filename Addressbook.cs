using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddressBookClass
    {
        List<Contacts> add = new List<Contacts>();
        public void AddContact()
        {
            Contacts con = new Contacts();
            Console.WriteLine("Enter First Name");
            con.First_Name = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            con.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            con.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            con.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            con.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            con.Zip = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            con.Phone_number = long.Parse(Console.ReadLine());

            add.Add(con);
        }

        public void Display()
        {
            foreach (Contacts data in add)
            {
                Console.WriteLine("Firstname:" + data.First_Name);
                Console.WriteLine("Lastname:" + data.Last_Name);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("city:" + data.City);
                Console.WriteLine("state:" + data.State);
                Console.WriteLine("Zipcode:" + data.Zip);
                Console.WriteLine("PhoneNumber:" + data.Phone_number);

            }
        }

    }
}
