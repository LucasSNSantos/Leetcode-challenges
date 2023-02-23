using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Solutions
{
    public class SolutionNumberPalindrome
    {
        public bool IsPalindrome(int x)
        {
            string stringfiedNumber = x.ToString();
            string reversedStringfiedNumber = new string(x.ToString().Reverse().ToArray());
            return stringfiedNumber == reversedStringfiedNumber;
        }
    }
}
