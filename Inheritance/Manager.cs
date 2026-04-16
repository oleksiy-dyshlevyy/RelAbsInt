using System;
using System.Collections.Generic;
using System.Text;

namespace RelAbsInt.Inheritance;

    public class Manager: User
    {
        public string Company { get; set; }

        public Manager()
        {
            Name = "Vania";
            Company = "SomeCompany";
        }
    }

