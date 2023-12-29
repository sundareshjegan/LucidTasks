using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Employee
    {
        private int id;
        private String name;
        private float salary;
        public Employee(int id,String name,float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void displayDetails()
        {
            Console.WriteLine($"Employee id : {id} \nName : {name} \nSalary : {salary}");
        }
    }
}
