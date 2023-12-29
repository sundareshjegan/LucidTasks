using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Student
    {
        int id;//data member (also instance variable)    
        String name;//data member(also instance variable)    

        public static void Main(string[] args)
        {
            Student s1 = new Student();//creating an object of Student    
            s1.id = 37;
            s1.name = "Sundareshwaran";
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);

            OtherClass f = new OtherClass();
            Console.WriteLine(f.id);
            Console.WriteLine(f.name);


            //Store details of Employee
            Console.WriteLine("Store Details of employee using class");
            Employee emp1 = new Employee(100, "Sundar", 900000);
            Employee emp2 = new Employee(101, "Mani", 800000);

            emp1.displayDetails();
            emp2.displayDetails();

            //structs
            Console.WriteLine("\nStructs..");
            Square sq = new Square(10);
            sq.printArea();

            Console.Read();
        }
    }
}
    
