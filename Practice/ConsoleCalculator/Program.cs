using System;
namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter the expression : ");
                string expression = Console.ReadLine();
                Console.WriteLine(Evaluate(expression));
            }
        }
        public static double Evaluate(string expression)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                System.Data.DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);
            }
            catch { Console.WriteLine("Invalid Expression"); }
            return 0.0;
        }
    }
}
