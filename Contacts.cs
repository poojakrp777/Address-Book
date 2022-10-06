﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    internal class Contacts
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public string Address { get; set; }
        public string State { get; set; }

        public string City { get; set; }

        public int Zip { get; set; }
        public long Phone_number { get; set; }

        public string Email { get; set; }
    }
}
