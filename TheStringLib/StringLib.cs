using System;

namespace TheStringLib
{
    public static class StringLib
    {
        public static string Reverse(string a)
        {
            var charArr = a.ToCharArray();             //ToCharArray turns input string into an array charArr reseaves input
            var reversedString = "";
            for (int idx = 0; idx < a.Length; idx++)    //how idx will change for the equation
            {
                var idx2 = a.Length - idx - 1;
                reversedString += charArr[idx2];
            }
            return reversedString;

        }
        public static string Rotate(string a)
        {
            return a[a.Length - 1] + a.Substring(0, a.Length - 1);   //+ is a concatination  Substring(where to start, how many to take)
        }
        public static string RemoveVowels(string a)
        {
            var vowels = new char[]
            {
                'a','e','i','o','u','A','E','I','O','U'                  //reference array
            };
            var pos = a.IndexOfAny(vowels);        // IndexOfAny - if it finds no match in vowel array it returns -1
            while (pos > -1)                       // causes indexofany to run until no match is found
            {
                a = a.Remove(pos, 1);              // (start idx, number to remove)
                pos = a.IndexOfAny(vowels);
            }
            return a;
        }    
    }
}






//charrArr = {a, b, c, d}
//charArr[0] // a => charArr[3]  4 - [0] - 1
//charArr[1] // b => charArr[2]  4 - [1] - 1
//charArr[2] // c => charArr[1]  4 - [2] - 1
//charArr[3] // d => charArr[0]  4 - [3] - 1
