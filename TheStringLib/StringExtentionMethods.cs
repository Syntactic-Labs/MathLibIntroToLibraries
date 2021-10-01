using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStringLib
{
    public static class StringExtentionMethods                         //!!!Extention Methods!!!         Must be static... all of it
    {
        public static int ConcatInt(this int i, int j)        //i is 7  j is 3  j is also 5        (this) creates the extention
        {
            return i * 10 + j;
        }
        public static void Print(this int i)
        {
            Console.WriteLine($"Fred is {i} years old!");
        }
        public static void Print(this string str)
        {
            
            Console.WriteLine($"Fred is {str}");
            var s = $"Fred is {str}";
            Console.WriteLine(s);
            System.Diagnostics.Debug.WriteLine(s);     //goes to the output line
        }
    }
}
