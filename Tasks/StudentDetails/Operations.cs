using ConsoleTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Operations
    {
        //temporary list for operations -> At end of each operation temp is cleared
        internal static List<Student> temp = new List<Student>();

        internal static void CalculateRank(List<Student> studentsList)
        {
            Student stuRank = new Student();
            for (int i = 0; i < studentsList.Count; i++)
            {
                int tempRank = 1;
                for (int j = 0; j < studentsList.Count; j++)
                {
                    if (studentsList[i].TotalScored < studentsList[j].TotalScored)
                    {
                        tempRank++;
                    }
                }
                studentsList[i].Rank = tempRank;
            }
        }
        internal static void Print(List<Student> studentsList)
        {
            if(studentsList.Count == 0)
            {
                Console.WriteLine("Sorry... No data");
            }
            else
            {
                var table = new Table();
                table.SetHeaders("ID", "StudentName", "Maths", "Physics", "Chemistry", "Computer", "Total", "Percentage", "Cutoff", "Pass/Fail", "Rank");
                foreach (Student s in studentsList)
                {
                    string passFail = s.IsFail ? "Fail" : "Pass";
                    table.AddRow(s.ID + "", s.Name, s.MathsMark + "", s.PhysicsMark + "", s.ChemistryMark + "", s.ComputerMark + "", s.TotalScored + "", s.Percentage + "", s.CutOff + "", passFail, s.Rank + "");
                }
                Console.WriteLine(table.ToString());
            }
        }
        internal static void FilterByName(List<Student> studentsList)
        {
            Console.Write("Enter the student name : ");
            string name = Console.ReadLine().ToLower();
            //List<Student> temp = new List<Student>();
            foreach (Student s in studentsList)
            {
                if (s.Name.ToLower().Contains(name))
                {
                    temp.Add(s);
                }
            }
            Print(temp);
            temp.Clear();
        }
        internal static void FilterByPassFail(List<Student> studentsList)
        {
            Console.Write("Enter pass/fail : ");
            string passFail = Console.ReadLine().ToLower();
            List<Student> passList = new List<Student>();
            List<Student> failList = new List<Student>();
            foreach (Student s in studentsList)
            {
                if (s.IsFail)
                {
                    failList.Add(s);
                }
                else
                {
                    passList.Add(s);
                }
            }
            Print(passFail == "pass" ? passList : failList);
        }
        internal static void SortByName(List<Student> studentList)
        {
            //SortedSet<string> names = new SortedSet<string>();
            //foreach(Student s in studentList)
            //{
            //    names.Add(s.Name);
            //}
            //foreach(string name in names)
            //{
            //    foreach(Student s in studentList)
            //    {
            //        if(s.Name == name)
            //        {
            //            temp.Add(s);
            //        }
            //    }
            //}
            //Print(temp);
            //temp.Clear();

            temp = studentList.OrderBy(s => s.Name).ToList();
            Print(temp);
            temp.Clear();
        }
        internal static void SortByRank(List<Student> studentsList)

        {
            temp = studentsList.OrderBy(s => s.Rank).ToList();
            Print(temp);
            temp.Clear();
        }
        internal static void SortByCutOff(List<Student> studentsList)
        {
            Print(studentsList.OrderBy(s => s.CutOff).ToList());
        }
        internal static void UpdateDetails(List<Student> studentsList)
        {
            InputValidate.ValidateInt("Enter the student ID : ");
            int id = InputValidate.IntValue;
            Student studentUpdated = null;
            foreach (Student s in studentsList)
            {
                if (s.ID == id)
                {
                    studentUpdated = s;
                    temp.Add(studentUpdated);
                    break;
                }
            }
            if (studentUpdated == null)
            {
                Console.WriteLine("Invalid Student ID..!");
            }
            else
            {
                Print(temp);
                temp.Clear();
                Console.WriteLine("\n1. Update Name\n2. Update Marks");
                InputValidate.ValidateInt("Enter your choice(1/2) : ");
                int choice = InputValidate.IntValue;
                switch (choice)
                {
                    case 1:
                        InputValidate.ValidateString("Enter the new name : ");
                        string newName = InputValidate.StringValue;
                        studentUpdated.Name = newName;
                        break;
                    case 2:
                        Console.Write("Enter the Subject name : ");
                        string subjectName = Console.ReadLine().ToLower();
                        
                        if(subjectName == "maths")
                        {
                            InputValidate.ValidateMark($"Enter the new {subjectName} mark : ");
                            int newMark = InputValidate.Mark;
                            studentUpdated.MathsMark = newMark;
                        }
                        else if(subjectName == "physics")
                        {
                            InputValidate.ValidateMark($"Enter the new {subjectName} mark : ");
                            int newMark = InputValidate.Mark;
                            studentUpdated.PhysicsMark = newMark;
                        }
                        else if (subjectName == "chemistry")
                        {
                            InputValidate.ValidateMark($"Enter the new {subjectName} mark : ");
                            int newMark = InputValidate.Mark;
                            studentUpdated.ChemistryMark = newMark;
                        }
                        else if (subjectName == "computer")
                        {
                            InputValidate.ValidateMark($"Enter the new {subjectName} mark : ");
                            int newMark = InputValidate.Mark;
                            studentUpdated.ComputerMark = newMark;
                        }
                        else
                        {
                            Console.WriteLine("Please enter maths/physics/chemistry/computer");
                        }
                        studentUpdated.ComputerMark = studentUpdated.ComputerMark;
                        break;
                }
                CalculateRank(studentsList);
            }
        }
    }
}
