﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Sort_based_on_City
{
    public class ContactDataManager
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Int64 PhoneNumber { get; set; }
        public Int64 zip { get; set; }
        public string Email { get; set; }
        //ER
        public string AddressBookName { get; set; }
        public string Type { get; set; }
    }
}

