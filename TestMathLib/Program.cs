using System;
using MathLibIntroToLibraries;     //calls the my MathLibrary
using TheStringLib;                //calls the StringLib

namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            7.ConcatInt(3).ConcatInt(5).Print();         //7 is i     3 and 5 are both j
            






            //var x = "Fred";
            //x.Print();                             // All of this is connected to the StringExtentionMethod
            //(52).Print();
            //"Fred's friend".Print();


            //=====================================================================================================================================

            Console.WriteLine($"{MathLibrary.About}");

            Console.WriteLine($"Inverse: {MathLibrary.Inverse(5)}");
            Console.WriteLine($"Modulo: {3.Modulo(5)}");
            //========================================================================================================================
            Console.WriteLine($"Reverse Method!");
            var reversedString = StringLib.Reverse("abcd");
            Console.WriteLine($"{reversedString}");
            //======================================================================================================================
            Console.WriteLine($"Rotate Method!");
            var rotateString = StringLib.Rotate("abcd");
            Console.WriteLine($"{rotateString}");
            rotateString = StringLib.Rotate(rotateString);
            Console.WriteLine($"{rotateString}");
            rotateString = StringLib.Rotate(rotateString);
            Console.WriteLine($"{rotateString}");
            rotateString = StringLib.Rotate(rotateString);
            Console.WriteLine($"{rotateString}");
            //======================================================================================================================
            Console.WriteLine($"Remove Vowels!!");
            var removevowels = StringLib.RemoveVowels("Funny strings make for interest and unique outcomes");
            Console.WriteLine($"{removevowels}");
            Console.WriteLine($"{StringLib.RemoveVowels("Did this work how it should?")}");         //another way to execute.

        }
    }
}
