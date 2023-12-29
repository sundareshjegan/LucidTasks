using System;

namespace AgeConversion
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

        public static int LeapYearsBetween(int start, int end)
        {
            System.Diagnostics.Debug.Assert(start < end);
            return LeapYearsBefore(end) - LeapYearsBefore(start + 1);
        }
        public static int LeapYearsBefore(int year)
        {
            System.Diagnostics.Debug.Assert(year > 0);
            year--;
            return (year / 4) - (year / 100) + (year / 400);
        }

        public static void DateFormat()
        {
            Console.Write("Enter your birthdate (yyyy-mm-dd): ");
            string input = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(input);
            //DateTime birthDate = new DateTime(2003, 6, 26); // Input birth date here
            //DateTime currentDate = DateTime.Now; // Current date

            DateTime currentDate = new DateTime(2023, 9, 28); // Specific date


            // Calculate total days
            int totalDays = (int)(currentDate - birthDate).TotalDays;

            // Calculate total hours
            int totalHours = (int)(currentDate - birthDate).TotalHours;

            // Calculate total weeks and remaining days
            int totalWeeks = totalDays / 7;
            int remainingDaysAfterWeeks = totalDays % 7;

            // Calculate years, months and days
            int years = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                years--;

            int months = currentDate.Month - birthDate.Month;
            if (currentDate.Day < birthDate.Day)
                months--;

            if (months < 0)
                months += 12;

            int days = currentDate.Day - birthDate.Day;
            if (days < 0)
            {
                DateTime previousMonth = currentDate.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }

            Console.WriteLine($"{years} years {months} months {days} days");
            Console.WriteLine($"or {years * 12 + months} months {days} days");
            Console.WriteLine($"or {totalWeeks} weeks {remainingDaysAfterWeeks} days");
            Console.WriteLine($"or {totalDays} days");
            Console.WriteLine($"or {totalHours} hours");
        }
        public static void YearFormat()
        { 
            Console.Write("Enter the year : ");
            int year = int.Parse(Console.ReadLine());
            if (year < curr_year)
                Console.WriteLine($"Your age is {curr_year - year} years, {curr_month} months, and {curr_date} days.");
            else
                Console.WriteLine("Invalid years");
        }
        public static void DayFormat()
        {
            Console.Write("Enter total number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            // Start from a fixed time (e.g., January 1, 2000)
            DateTime startDate = new DateTime(2000, 1, 1);
            DateTime targetDate = startDate.AddDays(totalDays);

            // Calculate difference
            int years = targetDate.Year - startDate.Year;
            int months = targetDate.Month - startDate.Month;
            int days = targetDate.Day - startDate.Day;

            // Adjust for leap years
            if (targetDate.DayOfYear < startDate.DayOfYear)
            {
                years--;
                months += 12;
            }

            if (targetDate.Day < startDate.Day)
            {
                months--;
                days += DateTime.DaysInMonth(targetDate.Year, targetDate.Month);
            }

            Console.WriteLine("{0} years {1} months {2} days", years, months, days);
        }
        public static void WeekFormat()
        {
            Console.Write("Enter total number of weeks: ");
            int totalWeeks = Convert.ToInt32(Console.ReadLine());

            // Convert weeks to days
            int totalDays = totalWeeks * 7;

            // Start from a fixed point in time (e.g., January 1, 2000)
            DateTime startDate = new DateTime(2000, 1, 1);
            DateTime targetDate = startDate.AddDays(totalDays);

            // Calculate difference
            int years = targetDate.Year - startDate.Year;
            int months = targetDate.Month - startDate.Month;
            int days = targetDate.Day - startDate.Day;

            // Adjust for leap years
            if (targetDate.DayOfYear < startDate.DayOfYear)
            {
                years--;
                months += 12;
            }

            if (targetDate.Day < startDate.Day)
            {
                months--;
                days += DateTime.DaysInMonth(targetDate.Year, targetDate.Month);
            }

            Console.WriteLine("{0} years {1} months {2} days", years, months, days);

        }
        public static void MonthFormat()
        {
            Console.Write("Enter total months: ");
            int totalMonths = Convert.ToInt32(Console.ReadLine());

            int years = totalMonths / 12;
            int months = totalMonths % 12;
            int days = 0;

            // Considering leap years
            if (DateTime.IsLeapYear(DateTime.Now.Year) && months > 2)
            {
                days = 2; // Adding two days for February in leap year
            }
            else if (months == 2)
            {
                days = DateTime.DaysInMonth(DateTime.Now.Year, 2) - 28; // Days in February minus standard 28 days
            }

            Console.WriteLine($"{years} years {months} months {days} days");

        }   

        static void Main()
        {
            int choice = 0;
            do
            {
                Console.Write("\nInput Format Choices : \n----- ------ -------\n1. yyyy-mm-dd\n2. years\n3. Month\n4. Week\n5. Days\n6. Exit\nSelect your choice : (1/2/3/4/5/6) : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DateFormat();
                        //Console.Read();
                        break;
                    case 2:
                        YearFormat();
                        break;
                    case 3:
                        MonthFormat();
                        break;
                    case 4:
                        WeekFormat();
                        break;
                    case 5:
                        DayFormat();
                        break;
                    case 6:
                        Console.WriteLine("Bye...(^_^)");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..!");
                        break;
                }
            } while (choice != 6);
        }
    }
}
