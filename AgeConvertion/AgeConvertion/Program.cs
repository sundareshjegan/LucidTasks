using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeConvertion
{
    class AgeCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age in years, months, weeks or days:");
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int age = int.Parse(splitInput[0]);
            string type = splitInput[1]; 

            int currentYear = 2023; 
            int currentMonth = 9; 
            int currentDay = 27; 

            int birthYear, birthMonth, birthDay;

            switch (type)
            {
                case "years":
                    birthYear = currentYear - age;
                    birthMonth = currentMonth;
                    birthDay = currentDay;
                    break;
                case "months":
                    birthYear = currentYear - age / 12;
                    birthMonth = currentMonth - age % 12;
                    if (birthMonth <= 0)
                    {
                        birthYear--;
                        birthMonth += 12;
                    }
                    birthDay = currentDay;
                    break;
                case "weeks":
                    birthYear = currentYear - (age * 7) / 365;
                    int days = (age * 7) % 365;
                    birthMonth = currentMonth;
                    while (days > 30)
                    {
                        birthMonth--;
                        if (birthMonth == 0)
                        {
                            birthYear--;
                            birthMonth = 12;
                        }
                        days -= 30;
                    }
                    birthDay = currentDay - days;
                    if (birthDay <= 0)
                    {
                        birthMonth--;
                        if (birthMonth == 0)
                        {
                            birthYear--;
                            birthMonth = 12;
                        }
                        birthDay += 30;
                    }
                    break;
                case "days":
                    birthYear = currentYear - age / 365;
                    int remainingDays = age % 365;
                    birthMonth = currentMonth;
                    while (remainingDays > 30)
                    {
                        birthMonth--;
                        if (birthMonth == 0)
                        {
                            birthYear--;
                            birthMonth = 12;
                        }
                        remainingDays -= 30;
                    }
                    birthDay = currentDay - remainingDays;
                    if (birthDay <= 0)
                    {
                        birthMonth--;
                        if (birthMonth == 0)
                        {
                            birthYear--;
                            birthMonth = 12;
                        }
                        birthDay += 30;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter age in years, months, weeks or days.");
                    Console.Read();
                    return;
            }

            int years = currentYear - birthYear;
            if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
                years--;

            Console.WriteLine("Age is: " + years + " years");
            Console.Read();
        }
    }
}
