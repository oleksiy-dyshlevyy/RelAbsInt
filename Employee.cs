using System;
using System.Collections.Generic;
using System.Text;


    public class Employee
    {
        public string firstName;
        public string lastName;
        public Date birthDate;
        public Date hireDate;

        public Employee ()
        {
            firstName = "Vasia";
            lastName = "Pupkin";
            birthDate = new Date();
            hireDate = new Date()
            {
                day = 15,
                month = 5,
                year = 2015
            };
        }

        public Employee (string fN, string lN, Date bD, Date hD)
        {
            firstName = fN;
            lastName = lN;
            birthDate = bD;
            hireDate = hD;
        }

        public void Hiring(params Employee[] employees)
        { }

        public void Hiring(string skill,  Employee employee)
        { }
    }

