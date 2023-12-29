using System;
using System.Collections.Generic;

namespace MergeRange
{
    class Range
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Value { get; set; }
    }
    class Operations
    { 
        internal static bool checkToMerge(Range start, Range end)
        {
            int max = Math.Max(start.Start, end.Start);
            int min = Math.Min(start.End, end.End);
            return max - min <= 0;
        }
        internal static void printRanges(List<Range> ranges)
        {
            Console.WriteLine("Ranges\t\tValue");
            foreach(Range range in ranges)
            {
                Console.WriteLine(range.Start + " - " + range.End+"\t\t  " + range.Value);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Range> ranges = new List<Range>();
            while (true)
            {
                int listSize = ranges.Count;
                Range newRange = new Range();

                ValidateInt("Enter the Start Range : ");
                newRange.Start = IntValue;

                ValidateInt("Enter the End Range : ");
                newRange.End = IntValue;

                ValidateInt("Enter the value : ");
                newRange.Value = IntValue;

                for (int i = 0; i < listSize; i++)
                {
                    if (Operations.checkToMerge(ranges[i], newRange))
                    {
                        newRange.Start = Math.Min(ranges[i].Start, newRange.Start);
                        newRange.End = Math.Max(ranges[i].End, newRange.End);
                        newRange.Value += ranges[i].Value;
                        ranges.Remove(ranges[i]);
                        i--;
                        listSize--;
                    }
                }
                ranges.Add(newRange);
                Operations.printRanges(ranges);
            }
        }
        #region ValidateInteger
        private static int IntValue = 0;
        private static void ValidateInt(string text)
        {
            Console.Write(text);
            bool parse = int.TryParse(Console.ReadLine(), out IntValue);
            if (!parse)
            {
                Console.WriteLine("Please enter Integer value..!");
                ValidateInt(text);
            }
        }
        #endregion
    }
}
