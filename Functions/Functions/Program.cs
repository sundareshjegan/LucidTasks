using System;

//Implementation of out and ref

namespace Functions
{
    /*
     * Out is similiar to ref but ref is two way based (caller <--> callee) whereas out is one way based (callee --> caller) ie., the parameters 
     * sent by the caller function is discarded
     */
    class Program
    {
        //out implementation
        public void Show_out(out int val) // Out parameter  
        {
            val = 10; // value must be initialized again (5 is changed to 10)
            val *= val;  //val is squared
        }
        //ref implementation
        public void Show_ref(ref int val) // Out parameter  
        {
            val *= val; // val is squared  
        }
        static void Main()
        {
            int val = 5;
            Program program = new Program();
            Console.WriteLine("Value before passing out variable " + val);
            program.Show_ref(ref val);
            Console.WriteLine("Value after recieving the ref variable " + val);
            program.Show_out(out val);
            Console.WriteLine("Value after recieving the out variable " + val);

            Console.ReadLine();
            
        }
    }
}
