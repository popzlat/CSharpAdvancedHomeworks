using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.StringExtension
{
    public static class Extensions
    {
        public static string ReverseString(this string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--) {
                reverse += cArray[i];
            }
            return reverse;

        }
        public static bool IsPalindrom(this string text )
        {
            string newString = text.Replace(" ", "").Replace(",", "").Replace("'", "").Replace("!","").ToLower();
            string reversed = newString.ReverseString().ToLower();
            if (newString == reversed) {
                return true;
            }
            else {
                return false;
            }
        }
        public static bool IsPalindrom(this int number)
        {
            string strNum = number.ToString();
            char[] array = strNum.ToCharArray();
            return CharArray(array);


        }
        public static bool IsPalindrom(this long number)
        {
            string strNum = number.ToString();

            char[] array = strNum.ToCharArray();
            return CharArray(array);



        }
        public static bool IsPalindrom(this double number)
        {
            string strNum = number.ToString();
            char[] array = strNum.ToCharArray();
            return CharArray(array);

        }
        public static bool CharArray (this char[] array)
        {
            string orgArray = new string(array);
            Array.Reverse(array);
            string reversed = new string(array);
            return orgArray == reversed;
        }
       

    }


}

