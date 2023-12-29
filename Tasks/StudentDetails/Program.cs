using System;
using System.Collections.Generic;

namespace StudentDetails
{
    class Program
    {
        private static int stuID = 1;
        private static List<Student> studentsList= new List<Student>();

        private static void addStudent()
        {
            Console.WriteLine($"\n\t\tStudent {stuID} Details\n\t\t------- -- -------");
            Student stu = new Student();
            stu.ID = stuID;

            InputValidate.ValidateString($"Enter student {stuID} name : ");
            stu.Name = InputValidate.StringValue;

            InputValidate.ValidateMark("Enter Maths mark     : ");
            stu.MathsMark = InputValidate.Mark;

            InputValidate.ValidateMark("Enter Physics mark   : ");
            stu.PhysicsMark = InputValidate.Mark;

            InputValidate.ValidateMark("Enter Chemistry mark : ");
            stu.ChemistryMark = InputValidate.Mark;
            
            InputValidate.ValidateMark("Enter Computer mark  : ");
            stu.ComputerMark = InputValidate.Mark;

            studentsList.Add(stu);
            Operations.CalculateRank(studentsList);
            stuID++;
        }
        private static void removeStudent()
        {
            InputValidate.ValidateInt("Enter the student ID to remove : ");
            int id = InputValidate.IntValue;
            if(id <= 0)
            {
                Console.WriteLine("Invalid Student ID..!");
            }
            else
            {
                Student studentRemoved = null;
                foreach (Student s in studentsList)
                {
                    if (s.ID == id)
                    {
                        studentRemoved = s;
                        break;
                    }
                }
                if (studentRemoved == null)
                {
                    Console.WriteLine("Invalid Student ID..!");
                }
                else
                {
                    Console.Write("This operation cannot be redone..! continue ? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y")
                        studentsList.Remove(studentRemoved);
                }
            }
        }
        static void Main(string[] args)
        {
            
            string choices = "\n\tOPERATIONS\n\t----------\n1. Add Student Details\n2. Remove Student\n3. Print all Student Details\n4. Update Student Details\n5. Filters\n6. Sort\n7. Exit\n";
            string filterChoices = "\n1. Filter By student name \n2. Filter By pass/fail \n";
            string sortChoices = "\n1. Sort By Name\n2. Sort By Rank\n3. Sort By cutoff";

            int choice = 0;
            do
            {
                Console.WriteLine(choices);
                InputValidate.ValidateInt("Enter your choice (1/2/3/4/5/6/7) : ");
                choice = InputValidate.IntValue;
                switch (choice)
                {
                    case 1:
                        addStudent();
                        break;
                    case 2:
                        removeStudent();
                        break;
                    case 3:
                        Operations.Print(studentsList);
                        break;
                    case 4:
                        Operations.UpdateDetails(studentsList);
                        break;
                    case 5:
                        Console.Write($"Filter Choices\n------ ------\n{filterChoices}\n");
                        InputValidate.ValidateInt("Enter your choice : ");
                        int filer_choice = InputValidate.IntValue;
                        switch (filer_choice)
                        {
                            case 1:
                                Operations.FilterByName(studentsList);
                                break;
                            case 2:
                                Operations.FilterByPassFail(studentsList);
                                break;
                        }
                        break;
                    case 6:
                        Console.Write($"Sort Choices\n------ ------\n{sortChoices}\n");
                        InputValidate.ValidateInt("Enter your choice : ");
                        int sortChoice = InputValidate.IntValue;
                        switch (sortChoice)
                        {
                            case 1:
                                Operations.SortByName(studentsList);
                                break;
                            case 2:
                                Operations.SortByRank(studentsList);
                                break;
                            case 3:
                                Operations.SortByCutOff(studentsList);
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Bye..");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..!");
                        break;
                }
            } while (choice != 7);
            Console.ReadLine();
        }
    }
}