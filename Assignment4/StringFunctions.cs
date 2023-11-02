using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment4
{
    public class StringFunctions
    {
        public static int FindChars(string str)
        {
            return str.Length;
        }
        public static bool CheckPalindrome(string str)
        {
            int l = 0, r = str.Length-1;
            
            while(l < r)
            {
                if (str[l] != str[r])
                {
                    return false;
                }
                l++;
                r--;
            }
            return true;
        }
        public static string Reverse(string str)
        {
            str = (string)str.Reverse();
            return str;
        }
        public static string Counts(string str)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = str.ToLower().Count(x => vowels.Contains(x));
            List<char> consonants = new List<char>() { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            int consonantCount=str.ToLower().Count(x=>consonants.Contains(x));
            //List<char> integers = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int integerCount = str.Count(char.IsDigit);
            int specialCharCount = str.Length - (vowelCount + consonantCount + integerCount);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"number of vowels : {vowelCount}");
            sb.AppendLine($"number of consonants : {consonantCount}");
            sb.AppendLine($"number of integers: {integerCount}");
            sb.AppendLine($"number of special characters: {specialCharCount}");
            return sb.ToString();
        }
        public static string Upper(string str)
        {
            return str.ToUpper();
        }
        public static string Proper(string str)
        {
            TextInfo tf = new CultureInfo("en-US",false).TextInfo;
            return tf.ToTitleCase(str);
        }
        public static string Combine(string left,string right)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(left);
            sb.Append(right);
            return sb.ToString();
        }
        public static string RemoveExtraSpace(string str)
        {
            string[] words=str.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ",words);
        }
        public static int CountWords(string str)
        {
            string[] word=str.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            return word.Length;
        }
        public static bool CheckPresent(string str,string substring)
        {
            if (str.Contains(substring)) return true;
            return false;
        }
        public static int SubstringOccurances(string str,string substring)
        {
            int ans = Regex.Matches(str,Regex.Escape(substring)).Count();
            return ans;
        }


    }
}
