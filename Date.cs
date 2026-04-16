using System;
using System.Collections.Generic;
using System.Text;


    public class Date
    {
        public int day;
        public int month;
        public int year;

        public Date ()
        {
            day = 1;
            month = 1;
            year = 1970;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
    }

