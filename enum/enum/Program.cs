using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    public class EnumExample
    {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void Main()
        {
            foreach(string s in Enum.GetNames(typeof(Days)))
            {
                Console.Write(s + " ");
            }
            Console.Read();
        }
    }
}
