using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Data
    {
        private int day;
        private int month;
        private int year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public Data()
        {
            day = DateTime.Today.Day;
            month = DateTime.Today.Month;
            year = DateTime.Today.Year;
        }

        public Data(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string Conv()
        {
            return day.ToString() + "." + month.ToString() + "." + year.ToString(); 
        }

        public static Data operator +(Data date, int days)
        {
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);
            dateTime = dateTime.AddDays(days);
            return new Data(dateTime.Day, dateTime.Month, dateTime.Year);
        }

        public static int operator -(Data date1, Data date2)
        {
            DateTime d1 = new DateTime(date1.Year, date1.Month, date1.Day);
            DateTime d2 = new DateTime(date2.Year, date2.Month, date2.Day);
            var span = d2 - d1;
            return Convert.ToInt32(span.TotalDays);
        }

        public static bool operator ==(Data date1, Data date2)
        {
            bool f = true;
            DateTime d1 = new DateTime(date1.Year, date1.Month, date1.Day);
            DateTime d2 = new DateTime(date2.Year, date2.Month, date2.Day);
            var span = d2 - d1;
            if (Convert.ToInt32(span.TotalDays) != 0)
            {
                f = false;
            }
            return f;
        }

        public static bool operator !=(Data date1, Data date2)
        {
            bool f = true;
            DateTime d1 = new DateTime(date1.Year, date1.Month, date1.Day);
            DateTime d2 = new DateTime(date2.Year, date2.Month, date2.Day);
            var span = d2 - d1;
            if (Convert.ToInt32(span.TotalDays) == 0)
            {
                f = false;
            }
            return f;
        }
    }
}
