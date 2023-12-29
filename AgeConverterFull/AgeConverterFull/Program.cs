using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeConverterFull
{
    class Program
    {
        public static DateTime currentDate = DateTime.Now;
        public static string[] dateAndTime = currentDate.ToString().Split(' ');
        public static string[] ddmmyy = dateAndTime[0].Split('-');
        public string time = dateAndTime[1];

        public static int curr_month = int.Parse(ddmmyy[1]);
        public static int curr_date = int.Parse(ddmmyy[0]);
        public static int curr_year = int.Parse(ddmmyy[2]);

        static void displayAge(int year, int month, int days)
        {
            Console.WriteLine($"Your age is {year} years, {month} months, {days} days.");
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age in year,months,weeks,days (ex : 10 years) :");
            string[] input = Console.ReadLine().Split(' ');
            int age = int.Parse(input[0]);
            string type = input[1].ToLower();
            int months = 0, days = 0;
            switch (type)
            {
                case "years":
                    displayAge(year,)
                    break;
            }
        }
    }
}
