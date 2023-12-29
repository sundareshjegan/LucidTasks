using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation1
{
    public static class InputValidate
    {
        public static int intValue = 0;
        public static void ValidateInt(string text)
        {
            Console.Write(text);
            if(!(int.TryParse(Console.ReadLine(),out intValue))){
                ValidateInt(text);
            }
        }
    }
}
