using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class Staff
    {
        public delegate void staffHandler(int i);
        public staffHandler Obj = null;

        Student stud = new Student();
        
        
        public static void CallMain(int i)
        {
            //Obj.Invoke(i);
        }
        
        
    }
}
